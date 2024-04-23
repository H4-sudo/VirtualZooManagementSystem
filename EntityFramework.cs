using System.Data.Entity;

namespace VirtualZooManagementSystem
{
    public class ZooContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
    }
}
