using Microsoft.EntityFrameworkCore;

namespace iFoodDbMap.EFCore
{
    public class IFoodDB : DbContext
    {
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
    }
}
