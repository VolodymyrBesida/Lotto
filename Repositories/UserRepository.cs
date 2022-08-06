using Microsoft.EntityFrameworkCore;
using TestTaskOnSea.Models;
using TestTaskOnSea.Repositories.Interfaces;

namespace TestTaskOnSea.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var user = _context.Users.Where(u => u.Id == id)
                                           .FirstOrDefault();
            if(user != null)
                _context.Users.Remove(user);
        }

        public async Task<IEnumerable<User>> GetAllAsync() 
            => await _context.Users.ToArrayAsync();

        public async Task<User> GetByEmailAsync(string email)
        {
            var user = await _context.Users.Where(u => u.Email == email)
                                           .FirstOrDefaultAsync();
            return user;
        }

        public async Task<User> GetByIdAsync(int id)
        {
            var user = await _context.Users.Where(u => u.Id == id)
                                           .FirstOrDefaultAsync();
            return user;
        }

        public async Task<User> GetByUserNameAsync(string userName)
        {
            var user = await _context.Users.Where(u => u.Name == userName)
                                           .FirstOrDefaultAsync();
            return user;
        }

        public async Task<User> GetByLoginAsync(string login)
        {
            var user = await _context.Users.Where(u => u.Login == login)
                                           .FirstOrDefaultAsync();
            return user;
        }

        public void Update(User user)
        {
            var userUpdate = _context.Users.Where(u => u.Id == user.Id)
                                                 .FirstOrDefault();
            if(userUpdate != null)
            {
                userUpdate.Login = user.Login;
                userUpdate.Email = user.Email;
                userUpdate.Name = user.Name;
                userUpdate.Surname = user.Surname;
                userUpdate.Age = user.Age;
            }
        }

        public void AddUser(User user)
            => _context.Users.Add(user);

    }
}
