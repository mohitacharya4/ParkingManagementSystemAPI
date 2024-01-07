using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingManagementSystemAPI.Models;
using ParkingManagementSystemAPI.Services;
using ParkingManagementSystemAPI.Services.Repositories;

namespace ParkingManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingSlotsController : ControllerBase
    {
        private readonly IParkingSlotRepository _parkingSlotRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly SlotAssignmentService _slotAssignmentService;

        public ParkingSlotsController(IParkingSlotRepository parkingSlotRepository, IUnitOfWork unitOfWork, SlotAssignmentService slotAssignmentService)
        {
            _parkingSlotRepository = parkingSlotRepository;
            _unitOfWork = unitOfWork;
            _slotAssignmentService = slotAssignmentService;
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
        public async Task<IActionResult> AssignSlot(ParkingAssignment assignment)
        {
            var slotNumber = _slotAssignmentService.AssignSlot(assignment.VehicleType, await _parkingSlotRepository.GetAvailableSlots());
            if (slotNumber == -1)
            {
                return BadRequest("No suitable slots available");
            }

            // Ensure assignment has a valid ID before updating
            if (assignment.Id == null)
            {
                return BadRequest("Assignment ID is required for update");
            }

            assignment.SlotId = slotNumber;

            // Clarify intent: Update parking slot or parking assignment?
            try
            {
                // If updating parking slot:
                await _parkingSlotRepository.UpdateSlot(slotNumber, assignment.VehicleType); // Assuming this method exists

                // If updating parking assignment:
                await _parkingAssignmentRepository.Update(assignment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating parking slot or assignment"); // Assuming a logger is available
                return StatusCode(500, "Failed to update slot or assignment");
            }

            await _unitOfWork.CompleteAsync();

            return Ok(assignment);
        }

        // PUT: Mark a slot as available
        [HttpPut("{slotNumber}/release")]
        public async Task<IActionResult> ReleaseSlot(int slotNumber)
        {
            try
            {
                var existingSlot = await _parkingSlotRepository.GetSlotById(slotNumber);
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
                await _unitOfWork.CompleteAsync();

                return Ok("Slot released successfully");
            }
            catch (Exception ex)
            {
                // Handle potential errors gracefully
                return StatusCode(500, "Error releasing slot: " + ex.Message);
            }
        }
    }
}
