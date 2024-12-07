using Microsoft.EntityFrameworkCore;

namespace HaziFeladat3.Context
{
    public class EFContext : DbContext
    {
        public DbSet<Models.Pet> Pets { get; set; }

        public DbSet<Models.Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=.//DB//pets.db");
        }
        //Ha megvan a Modell meg minden kell egy DB mappa
        //Ha kimaradt akkor Create > Folder > DB
        //Új command > Add-Migration AddPendingChanges
        //Console > Update-Database

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Models.Category>().HasData(
                new Models.Category { ID = 1, Name = "Dog", Description = "Domesticated dogs" },
                new Models.Category { ID = 2, Name = "Cat", Description = "Domesticated cats" },
                new Models.Category { ID = 3, Name = "Bird", Description = "Various bird species" }
            );
        }

    }
}
