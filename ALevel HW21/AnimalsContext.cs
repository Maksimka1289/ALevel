using Microsoft.EntityFrameworkCore;

namespace ALevel_HW21
{
    public class AnimalsContext : DbContext
    {
        private Microsoft.EntityFrameworkCore.DbContextOptions options;

        public AnimalsContext(DbContextOptions<AnimalsContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Location> Locations { get; set; }

    }
}
