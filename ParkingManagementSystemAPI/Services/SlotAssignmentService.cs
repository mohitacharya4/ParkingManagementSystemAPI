using ParkingManagementSystemAPI.Models;
using ParkingManagementSystemAPI.Services.Repositories;

namespace ParkingManagementSystemAPI.Services
{
    public class SlotAssignmentService : ISlotAssignmentService
    {
        private readonly IParkingSlotRepository _parkingSlotRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SlotAssignmentService(IParkingSlotRepository parkingSlotRepository, IUnitOfWork unitOfWork)
        {
            _parkingSlotRepository = parkingSlotRepository;
            _unitOfWork = unitOfWork;
        }

        public int AssignSlot(string vehicleType, List<ParkingSlot> availableSlots)
        {
            // Implement your slot assignment logic here, prioritizing best-matching slots and handling unavailability
            // For example:
            var compatibleSlots = availableSlots.Where(s => s.SlotType.IsCompatibleWith(vehicleType)).ToList();
            if (compatibleSlots.Any())
            {
                var bestMatchingSlot = compatibleSlots.OrderByDescending(s => s.SlotType).First();
                bestMatchingSlot.IsAvailable = false;
                _parkingSlotRepository.UpdateSlot(bestMatchingSlot);
                _unitOfWork.CompleteAsync();
                return bestMatchingSlot.SlotNumber;
            }
            else
            {
                return -1; // No suitable slots available
            }
        }
    }
}
