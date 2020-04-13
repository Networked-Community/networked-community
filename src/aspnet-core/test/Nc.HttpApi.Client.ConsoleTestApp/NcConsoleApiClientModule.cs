using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Nc.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(NcHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class NcConsoleApiClientModule : AbpModule
    {
        
    }
}
