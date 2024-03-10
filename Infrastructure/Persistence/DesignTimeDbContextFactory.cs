using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Persistence.Contexts;

namespace Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AgricultureAndAnimalHusbandryWebAPIDbContext>
    {
        public AgricultureAndAnimalHusbandryWebAPIDbContext CreateDbContext(string[] args)
        {


            DbContextOptionsBuilder<AgricultureAndAnimalHusbandryWebAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConfigurationString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
