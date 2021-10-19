using Microsoft.EntityFrameworkCore;
using UnitTest_mok.Models;

namespace UnitTest_mok.Models
{
    public partial class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
