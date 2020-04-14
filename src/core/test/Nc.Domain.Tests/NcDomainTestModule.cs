using Nc.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Nc
{
    [DependsOn(
        typeof(NcEntityFrameworkCoreTestModule)
        )]
    public class NcDomainTestModule : AbpModule
    {

    }
}