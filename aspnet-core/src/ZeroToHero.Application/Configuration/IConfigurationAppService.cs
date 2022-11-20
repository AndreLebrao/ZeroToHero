using System.Threading.Tasks;
using ZeroToHero.Configuration.Dto;

namespace ZeroToHero.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
