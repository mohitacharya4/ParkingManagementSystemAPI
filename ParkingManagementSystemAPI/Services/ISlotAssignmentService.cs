using ParkingManagementSystemAPI.Models;

namespace ParkingManagementSystemAPI.Services
{
    public interface ISlotAssignmentService
    {
        int AssignSlot(string vehicleType, List<ParkingSlot> availableSlots);
    }
}
