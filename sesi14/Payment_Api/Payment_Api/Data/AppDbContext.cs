using Microsoft.EntityFrameworkCore;
using Payment_Api.Models;

namespace Payment_Api.Data
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<ItemData> Items {get; set;}
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}