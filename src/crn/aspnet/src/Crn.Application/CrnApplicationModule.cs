using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Crn.Authorization;

namespace Crn
{
    [DependsOn(
        typeof(CrnCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CrnApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CrnAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CrnApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
