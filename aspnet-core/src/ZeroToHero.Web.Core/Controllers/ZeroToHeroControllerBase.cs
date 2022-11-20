using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ZeroToHero.Controllers
{
    public abstract class ZeroToHeroControllerBase: AbpController
    {
        protected ZeroToHeroControllerBase()
        {
            LocalizationSourceName = ZeroToHeroConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
