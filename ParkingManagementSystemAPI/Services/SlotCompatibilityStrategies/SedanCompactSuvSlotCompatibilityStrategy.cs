using ParkingManagementSystemAPI.Enums;
using ParkingManagementSystemAPI.Services.SlotCompatibilityStrategies.Interfaces;

namespace ParkingManagementSystemAPI.Services.SlotCompatibilityStrategies
{
    public class SedanCompactSuvSlotCompatibilityStrategy : ISlotCompatibilityStrategy
    {
        public List<SlotType> GetCompatibleSlotTypes()
        {
            return new List<SlotType>() { SlotType.Medium, SlotType.Large };
        }
    }
}
