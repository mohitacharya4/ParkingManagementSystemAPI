using ParkingManagementSystemAPI.Models;

namespace ParkingManagementSystemAPI.Services.Repositories
{
    public interface IParkingSlotRepository
    {
        Task<List<ParkingSlot>> GetAvailableSlots();
        Task<ParkingSlot> GetSlotById(int slotId);
        Task<ParkingSlot> UpdateSlot(ParkingSlot slot);
    }
}
