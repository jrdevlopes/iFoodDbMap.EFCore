using iFoodDbMap.EFCore.Entity;
using iFoodDbMap.EFCore.Entity.Map;
using Microsoft.EntityFrameworkCore;

namespace iFoodDbMap.EFCore
{
    public class IFoodDB : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> ListAddress { get; set; }

        public string DbPath { get; }

        public IFoodDB()
        {
            var folder = Environment.SpecialFolder.Desktop;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "iFood.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientMap());
            modelBuilder.ApplyConfiguration(new AddressMap());
        }
    }
}
