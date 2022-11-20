using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ZeroToHero.Configuration.Dto;

namespace ZeroToHero.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ZeroToHeroAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
