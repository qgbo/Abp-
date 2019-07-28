using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using qgb48.Configuration;
using qgb48.Web;

namespace qgb48.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class qgb48DbContextFactory : IDesignTimeDbContextFactory<qgb48DbContext>
    {
        public qgb48DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<qgb48DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            qgb48DbContextConfigurer.Configure(builder, configuration.GetConnectionString(qgb48Consts.ConnectionStringName));

            return new qgb48DbContext(builder.Options);
        }
    }
}
