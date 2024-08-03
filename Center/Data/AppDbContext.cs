using Center.Models;
using Microsoft.EntityFrameworkCore;

namespace Center.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Matrial> Matrials { get; set; }
        public DbSet<MatrialsRecord> MatrialsRecord { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
