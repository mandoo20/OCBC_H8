using Microsoft.EntityFrameworkCore;
using TodoApp.Models;
using Microsoft.EntityFrameworkCore.Sqlite;


namespace TodoApp.Data{

    public class ApiDbContext : DbContext{
        public virtual DbSet<ItemData> Items {get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            
        }
    }
}