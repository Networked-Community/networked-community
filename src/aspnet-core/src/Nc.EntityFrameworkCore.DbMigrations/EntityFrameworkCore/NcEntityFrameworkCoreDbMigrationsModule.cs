using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Nc.EntityFrameworkCore
{
    [DependsOn(
        typeof(NcEntityFrameworkCoreModule)
        )]
    public class NcEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<NcMigrationsDbContext>();
        }
    }
}
