using Microsoft.EntityFrameworkCore;
using ParkingManagementSystemAPI.Data;
using ParkingManagementSystemAPI.Models;
using ParkingManagementSystemAPI.Repositories.Interfaces;

namespace ParkingManagementSystemAPI.Repositories
{
    public class VehicleTypeRepository : IVehicleTypeRepository
    {
        private readonly ParkingContext _context;

        public VehicleTypeRepository(ParkingContext context)
        {
            _context = context;
        }

        public async Task<List<VehicleType>> GetAllAsync()
        {
            return await _context.VehicleTypes.ToListAsync();
        }

        public async Task<VehicleType> GetByIdAsync(string vehicleTypeName)
        {
            return await _context.VehicleTypes.FindAsync(vehicleTypeName);
        }

        public async Task AddAsync(VehicleType vehicleType)
        {
            await _context.VehicleTypes.AddAsync(vehicleType);
        }

        public async Task UpdateAsync(VehicleType vehicleType)
        {
            _context.VehicleTypes.Update(vehicleType);
        }

        public async Task DeleteAsync(string vehicleTypeName)
        {
            var vehicleType = await _context.VehicleTypes.FindAsync(vehicleTypeName);
            if (vehicleType != null)
            {
                _context.VehicleTypes.Remove(vehicleType);
            }
        }
    }
}
