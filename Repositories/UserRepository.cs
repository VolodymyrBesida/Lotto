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

        public async void Delete(int id)
        {
            var user = await _context.Users.Where(u => u.Id == id)
                                           .FirstOrDefaultAsync();
            if(user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<User>> GetAll() 
            => await _context.Users.ToArrayAsync();

        public async Task<User> GetByEmail(string email)
        {
            var user = await _context.Users.Where(u => u.Email == email)
                                           .FirstOrDefaultAsync();
            return user;
        }

        public async Task<User> GetById(int id)
        {
            var user = await _context.Users.Where(u => u.Id == id)
                                           .FirstOrDefaultAsync();
            return user;
        }

        public async Task<User> GetByUserName(string userName)
        {
            var user = await _context.Users.Where(u => u.Name == userName)
                                           .FirstOrDefaultAsync();
            return user;
        }

        public async Task<User> GetByLogin(string login)
        {
            var user = await _context.Users.Where(u => u.Login == login)
                                           .FirstOrDefaultAsync();
            return user;
        }

        public async void Update(User user)
        {
            var userUpdate = await _context.Users.Where(u => u.Id == user.Id)
                                                 .FirstOrDefaultAsync();
            if(userUpdate != null)
            {
                userUpdate.Login = user.Login;
                userUpdate.Email = user.Email;
                userUpdate.Name = user.Name;
                userUpdate.Surname = user.Surname;
                userUpdate.Age = user.Age;

                await _context.SaveChangesAsync();
            }
        }

        public async Task<User> AddUser(User user)
        {
            var createdUser = await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return createdUser.Entity;
        }
    }
}
