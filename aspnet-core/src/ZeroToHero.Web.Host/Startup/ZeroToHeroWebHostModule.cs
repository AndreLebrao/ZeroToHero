using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ZeroToHero.Configuration;

namespace ZeroToHero.Web.Host.Startup
{
    [DependsOn(
       typeof(ZeroToHeroWebCoreModule))]
    public class ZeroToHeroWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ZeroToHeroWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ZeroToHeroWebHostModule).GetAssembly());
        }
    }
}
