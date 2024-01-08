using ParkingManagementSystemAPI.Models;

namespace ParkingManagementSystemAPI.Repositories.Interfaces
{
    public interface IParkingSlotRepository
    {
        Task<IEnumerable<ParkingSlot>> GetAllSlots();
        Task<IEnumerable<ParkingSlot>> GetAvailableSlots();
        Task<ParkingSlot> GetSlotById(int slotId);
        Task<ParkingSlot> UpdateSlot(ParkingSlot slot);
    }
}
