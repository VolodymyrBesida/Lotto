using Microsoft.EntityFrameworkCore;
using TestTaskOnSea.Models;

namespace TestTaskOnSea.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        
    }
}
