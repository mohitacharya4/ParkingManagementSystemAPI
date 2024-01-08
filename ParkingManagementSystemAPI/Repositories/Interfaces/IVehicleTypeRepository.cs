using ParkingManagementSystemAPI.Models;

namespace ParkingManagementSystemAPI.Repositories.Interfaces
{
    public interface IVehicleTypeRepository
    {
        Task<List<VehicleType>> GetAllAsync();
        Task<VehicleType> GetByIdAsync(string vehicleTypeName);
        Task AddAsync(VehicleType vehicleType);
        Task UpdateAsync(VehicleType vehicleType);
        Task DeleteAsync(string vehicleTypeName);
    }
}
