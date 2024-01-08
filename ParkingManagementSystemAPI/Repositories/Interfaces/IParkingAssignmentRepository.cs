using ParkingManagementSystemAPI.Models;

namespace ParkingManagementSystemAPI.Repositories.Interfaces
{
    public interface IParkingAssignmentRepository
    {
        Task<List<ParkingAssignment>> GetAllAsync();
        Task<ParkingAssignment> GetByIdAsync(int assignmentId);
        Task<ParkingAssignment?> GetActiveAssignmentForSlot(int slotId);
        Task AddAsync(ParkingAssignment assignment);
        Task UpdateAsync(ParkingAssignment assignment);
        Task DeleteAsync(int assignmentId);
    }
}
