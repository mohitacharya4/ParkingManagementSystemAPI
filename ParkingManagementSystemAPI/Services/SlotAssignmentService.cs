using ParkingManagementSystemAPI.Enums;
using ParkingManagementSystemAPI.Models;
using ParkingManagementSystemAPI.Repositories.Interfaces;
using ParkingManagementSystemAPI.Services.Interfaces;
using ParkingManagementSystemAPI.Services.SlotCompatibilityStrategies.Interfaces;
using ParkingManagementSystemAPI.Services.SlotCompatibilityStrategies;
using ParkingManagementSystemAPI.UnitOfWork.Interfaces;

namespace ParkingManagementSystemAPI.Services
{
    public class SlotAssignmentService : ISlotAssignmentService
    {
        private readonly IParkingSlotRepository _parkingSlotRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IVehicleTypeRepository _vehicleTypeRepository;

        public SlotAssignmentService(IParkingSlotRepository parkingSlotRepository, IUnitOfWork unitOfWork, 
            IVehicleTypeRepository vehicleTypeRepository)
        {
            _parkingSlotRepository = parkingSlotRepository;
            _unitOfWork = unitOfWork;
            this._vehicleTypeRepository = vehicleTypeRepository;
        }

        public async Task<int> AssignSlot(string vehicleType, IEnumerable<ParkingSlot> availableSlots)
        {
            var strategy = GetSlotCompatibilityStrategy(vehicleType);
            // Get compatible slot types for the vehicle
            var compatibleSlotTypes = strategy.GetCompatibleSlotTypes();

            foreach (var slotType in compatibleSlotTypes)
            {
                var matchingSlots = availableSlots.Where(s => s.SlotType == slotType).ToList();

                if (matchingSlots.Any())
                {
                    var bestMatchingSlot = matchingSlots.First();

                    bestMatchingSlot.IsAvailable = false;

                    await _parkingSlotRepository.UpdateSlot(bestMatchingSlot);
                    await _unitOfWork.CompleteAsync();

                    return bestMatchingSlot.SlotNumber;
                }
            }
            return -1;
        }

        private ISlotCompatibilityStrategy GetSlotCompatibilityStrategy(string vehicleType)
        {
            switch (vehicleType)
            {
                case "Hatchback":
                    return new HatchbackSlotCompatibilityStrategy();
                case "Sedan/Compact SUV":
                    return new SedanCompactSuvSlotCompatibilityStrategy();
                case "SUV or Large cars":
                    return new SuvLargeCarsSlotCompatibilityStrategy();
                default:
                    throw new InvalidOperationException($"Invalid vehicle type: {vehicleType}");
            }
        }
    }
}
