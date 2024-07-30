using Center.Models;
using Microsoft.EntityFrameworkCore;

namespace Center.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
