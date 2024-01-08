using ParkingManagementSystemAPI.Enums;

namespace ParkingManagementSystemAPI.Services.SlotCompatibilityStrategies.Interfaces
{
    public interface ISlotCompatibilityStrategy
    {
        List<SlotType> GetCompatibleSlotTypes();
    }
}
