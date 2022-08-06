using TestTaskOnSea.Models;

namespace TestTaskOnSea.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<User> GetByUserNameAsync(string userName);
        Task<User> GetByLoginAsync(string login);
        Task<User> GetByEmailAsync(string email);
        void AddUser(User user);
        void Update(User user);
        void Delete(int id);
    }
}
