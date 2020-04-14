using Nc.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Nc.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(NcEntityFrameworkCoreDbMigrationsModule),
        typeof(NcApplicationContractsModule)
        )]
    public class NcDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
