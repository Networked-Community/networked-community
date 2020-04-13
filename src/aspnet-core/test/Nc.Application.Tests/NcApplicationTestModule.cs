using Volo.Abp.Modularity;

namespace Nc
{
    [DependsOn(
        typeof(NcApplicationModule),
        typeof(NcDomainTestModule)
        )]
    public class NcApplicationTestModule : AbpModule
    {

    }
}