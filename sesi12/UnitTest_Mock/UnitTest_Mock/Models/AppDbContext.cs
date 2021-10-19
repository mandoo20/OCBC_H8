using Microsoft.EntityFrameworkCore;
using UnitTest_Mock.Models;

namespace UnitTest_Mock.Models
{
    public partial class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
    }
}
