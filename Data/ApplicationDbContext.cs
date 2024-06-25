using Microsoft.EntityFrameworkCore;
using TZVersta.Models;

namespace TZVersta.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}
