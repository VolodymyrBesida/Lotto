using TestTaskOnSea.Repositories.Interfaces;

namespace TestTaskOnSea.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository userRepository { get; }
        Task<bool> SaveAsync();
    }
}
