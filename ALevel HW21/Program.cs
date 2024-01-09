using ALevel_HW21;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

await using (AnimalsContext context = new AnimalsContentFactory().CreateDbContext(Array.Empty<string>()))
{
    context.Database.EnsureCreated();
}
