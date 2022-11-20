using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ZeroToHero.Authorization;

namespace ZeroToHero
{
    [DependsOn(
        typeof(ZeroToHeroCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ZeroToHeroApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ZeroToHeroAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ZeroToHeroApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
