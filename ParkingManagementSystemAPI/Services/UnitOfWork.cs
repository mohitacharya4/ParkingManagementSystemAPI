using ParkingManagementSystemAPI.Data;

namespace ParkingManagementSystemAPI.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ParkingContext _context;

        public UnitOfWork(ParkingContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
