using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ZeroToHero.EntityFrameworkCore;
using ZeroToHero.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ZeroToHero.Web.Tests
{
    [DependsOn(
        typeof(ZeroToHeroWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ZeroToHeroWebTestModule : AbpModule
    {
        public ZeroToHeroWebTestModule(ZeroToHeroEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ZeroToHeroWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ZeroToHeroWebMvcModule).Assembly);
        }
    }
}