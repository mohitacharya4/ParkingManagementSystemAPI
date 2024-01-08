namespace ParkingManagementSystemAPI.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
