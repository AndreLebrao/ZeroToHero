using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ZeroToHero.Configuration;
using ZeroToHero.EntityFrameworkCore;
using ZeroToHero.Migrator.DependencyInjection;

namespace ZeroToHero.Migrator
{
    [DependsOn(typeof(ZeroToHeroEntityFrameworkModule))]
    public class ZeroToHeroMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ZeroToHeroMigratorModule(ZeroToHeroEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ZeroToHeroMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ZeroToHeroConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ZeroToHeroMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
