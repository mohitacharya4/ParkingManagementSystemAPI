using ParkingManagementSystemAPI.Enums;
using ParkingManagementSystemAPI.Services.SlotCompatibilityStrategies.Interfaces;

namespace ParkingManagementSystemAPI.Services.SlotCompatibilityStrategies
{
    public class SuvLargeCarsSlotCompatibilityStrategy : ISlotCompatibilityStrategy
    {
        public List<SlotType> GetCompatibleSlotTypes()
        {
            return new List<SlotType>() { SlotType.Large };
        }
    }
}
