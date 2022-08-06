using TestTaskOnSea.Models;
using TestTaskOnSea.Repositories;
using TestTaskOnSea.Repositories.Interfaces;
using TestTaskOnSea.UnitOfWork.Interfaces;

namespace TestTaskOnSea.UnitOfWork
{
    #region Public Class Unit of Work
    public class UnitOfWork : IUnitOfWork
    {
        #region Private Attributes
        private readonly AppDbContext _context;
        #endregion
        #region Constructor

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        #endregion
        #region Public Methods

        public IUserRepository userRepository
            => new UserRepository(_context);

        public async Task<bool> SaveAsync()
        {
             return await _context.SaveChangesAsync() > 0;
        }
        #endregion
    }
    #endregion
}
