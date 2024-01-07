namespace ParkingManagementSystemAPI.Services
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
