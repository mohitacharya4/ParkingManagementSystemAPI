using ParkingManagementSystemAPI.Enums;
using ParkingManagementSystemAPI.Services.SlotCompatibilityStrategies.Interfaces;

namespace ParkingManagementSystemAPI.Services.SlotCompatibilityStrategies
{
    public class HatchbackSlotCompatibilityStrategy : ISlotCompatibilityStrategy
    {
        public List<SlotType> GetCompatibleSlotTypes()
        {
            return new List<SlotType>() { SlotType.Small, SlotType.Medium, SlotType.Large };
        }
    }
}
