using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Crn.Configuration;
using Crn.Web;

namespace Crn.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CrnDbContextFactory : IDesignTimeDbContextFactory<CrnDbContext>
    {
        public CrnDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CrnDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CrnDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CrnConsts.ConnectionStringName));

            return new CrnDbContext(builder.Options);
        }
    }
}
