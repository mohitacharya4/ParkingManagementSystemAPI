using Microsoft.EntityFrameworkCore;
using ParkingManagementSystemAPI.Data;
using ParkingManagementSystemAPI.Models;
using ParkingManagementSystemAPI.Repositories.Interfaces;

namespace ParkingManagementSystemAPI.Repositories
{
    public class ParkingSlotRepository : IParkingSlotRepository
    {
        private readonly ParkingContext _context;

        public ParkingSlotRepository(ParkingContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ParkingSlot>> GetAllSlots()
        {
            return await _context.ParkingSlots.AsNoTracking().ToListAsync();
        }
        
        public async Task<IEnumerable<ParkingSlot>> GetAvailableSlots()
        {
            return await _context.ParkingSlots.Where(s => s.IsAvailable).ToListAsync();
        }

        public async Task<ParkingSlot> GetSlotById(int slotId)
        {
            return await _context.ParkingSlots.FindAsync(slotId);
        }

        public async Task<ParkingSlot> UpdateSlot(ParkingSlot slot)
        {
            _context.ParkingSlots.Update(slot);
            await _context.SaveChangesAsync();
            return slot;
        }
    }
}
