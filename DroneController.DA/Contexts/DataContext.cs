using DroneController.DA.Models;
using Microsoft.EntityFrameworkCore;

namespace DroneController.DA.Contexts
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Drone> Drones { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Load> Loads { get; set; }
        public DbSet<LoadDetail> LoadDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Drones;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}
