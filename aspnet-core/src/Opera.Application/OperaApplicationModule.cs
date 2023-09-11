using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Opera.Authorization;

namespace Opera
{
    [DependsOn(
        typeof(OperaCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OperaApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OperaAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OperaApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
