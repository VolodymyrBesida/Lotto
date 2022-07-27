using TestTaskOnSea.Models;

namespace TestTaskOnSea.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(int id);
        Task<User> GetByUserName(string userName);
        Task<User> GetByLogin(string login);
        Task<User> GetByEmail(string email);
        Task<User> AddUser(User user);
        void Update(User user);
        void Delete(int id);
    }
}
