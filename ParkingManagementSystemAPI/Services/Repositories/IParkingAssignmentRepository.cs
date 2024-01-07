using ParkingManagementSystemAPI.Models;

namespace ParkingManagementSystemAPI.Services.Repositories
{
    public interface IParkingAssignmentRepository
    {
        Task<List<ParkingAssignment>> GetAllAsync();
        Task<ParkingAssignment> GetByIdAsync(int assignmentId);
        Task AddAsync(ParkingAssignment assignment);
        Task UpdateAsync(ParkingAssignment assignment);
        Task DeleteAsync(int assignmentId);
    }
}
