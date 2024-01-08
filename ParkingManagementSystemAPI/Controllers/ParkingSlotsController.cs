using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingManagementSystemAPI.Models;
using ParkingManagementSystemAPI.Models.Dto;
using ParkingManagementSystemAPI.Repositories.Interfaces;
using ParkingManagementSystemAPI.Services.Interfaces;
using ParkingManagementSystemAPI.UnitOfWork.Interfaces;

namespace ParkingManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingSlotsController : ControllerBase
    {
        private readonly IParkingSlotRepository _parkingSlotRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISlotAssignmentService _slotAssignmentService;
        private readonly IParkingAssignmentRepository _parkingAssignmentRepository;

        public ParkingSlotsController(IParkingSlotRepository parkingSlotRepository, IUnitOfWork unitOfWork, ISlotAssignmentService slotAssignmentService, IParkingAssignmentRepository parkingAssignmentRepository)
        {
            _parkingSlotRepository = parkingSlotRepository;
            _unitOfWork = unitOfWork;
            _slotAssignmentService = slotAssignmentService;
            _parkingAssignmentRepository = parkingAssignmentRepository;
        }

        // GET: Get all slots
        [HttpGet]
        public async Task<IActionResult> GetAllSlots()
        {
            var parkingSlots = await _parkingSlotRepository.GetAllSlots();

            List<AllParkingSlotsResponseDto> parkingSlotResponse = parkingSlots.Select(slot => new AllParkingSlotsResponseDto
            {
                SlotNumber = slot.SlotNumber,
                SlotType = slot.SlotType,
                IsAvailable = slot.IsAvailable
            }).ToList();

            return Ok(parkingSlotResponse);
        }
        
        // GET: Get all available slots
        [HttpGet("available")]
        public async Task<IActionResult> GetAvailableSlots()
        {
            var availableSlots = await _parkingSlotRepository.GetAvailableSlots();
            return Ok(availableSlots);
        }

        // POST: Assign a slot to a vehicle
        [HttpPost("assign")]
        public async Task<IActionResult> AssignSlot(AssignParkingSlotRequestDto assignParkingSlotRequestDto)
        {
            var slotNumber = await _slotAssignmentService.AssignSlot(assignParkingSlotRequestDto.VehicleType, await _parkingSlotRepository.GetAvailableSlots());
            if (slotNumber == -1)
            {
                return BadRequest("No suitable slots available");
            }

            // Use automapper to map from AssignParkingSlotDto to ParkingAssignment
            var assignment = new ParkingAssignment() { 
                SlotId = slotNumber,
                VehicleRegistrationNumber = assignParkingSlotRequestDto.VehicleRegistrationNumber,
                VehicleType = assignParkingSlotRequestDto.VehicleType,
                EntryTime = DateTime.UtcNow
            };

            await _parkingAssignmentRepository.UpdateAsync(assignment);
            await _unitOfWork.CompleteAsync();

            var assignedSlotDetails = new AssignParkingSlotResponseDto
            {
                SlotNumber = slotNumber
            };

            return Ok(assignedSlotDetails);
        }

        // PUT: Mark a slot as available
        [HttpPut("{slotNumber}/release")]
        public async Task<IActionResult> ReleaseSlot(int slotNumber)
        {
            try
            {
                var existingSlot = await _parkingSlotRepository.GetSlotById(slotNumber);
                var relatedAssignment = await _parkingAssignmentRepository.GetActiveAssignmentForSlot(slotNumber);

                if (existingSlot == null)
                {
                    return NotFound("Invalid slot number");
                }

                if (existingSlot.IsAvailable)
                {
                    return BadRequest("Slot is already available");
                }

                existingSlot.IsAvailable = true;
                await _parkingSlotRepository.UpdateSlot(existingSlot);

                if (relatedAssignment != null)
                {
                    relatedAssignment.ExitTime = DateTime.UtcNow;
                    await _parkingAssignmentRepository.UpdateAsync(relatedAssignment);
                }
                await _unitOfWork.CompleteAsync();

                return Ok("Slot released successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error releasing slot: " + ex.Message);
            }
        }
    }
}
