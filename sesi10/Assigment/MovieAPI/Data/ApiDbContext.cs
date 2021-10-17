using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;
using MySql.EntityFrameworkCore;


namespace MovieAPI.Data{

    public class ApiDbContext : DbContext{
        public virtual DbSet<MovieData> movie {get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            
        }
    }
}