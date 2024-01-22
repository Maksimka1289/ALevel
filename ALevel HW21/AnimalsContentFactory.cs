using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ALevel_HW21
{
    public class AnimalsContentFactory : IDesignTimeDbContextFactory<AnimalsContext>
    {
        public AnimalsContext CreateDbContext(string[] args)
        {
            var connectionString = "Data Source=localhost;Initial Catalog=Animals;TrustServerCertificate=True;Integrated Security=True;MultipleActiveResultSets=true";
            var optionsBuilder = new DbContextOptionsBuilder<AnimalsContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            return new AnimalsContext(options);
        }
    }
}
