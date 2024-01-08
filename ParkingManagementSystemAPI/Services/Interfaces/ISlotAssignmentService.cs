using ParkingManagementSystemAPI.Models;

namespace ParkingManagementSystemAPI.Services.Interfaces
{
    public interface ISlotAssignmentService
    {
        Task<int> AssignSlot(string vehicleType, IEnumerable<ParkingSlot> availableSlots);
    }
}
