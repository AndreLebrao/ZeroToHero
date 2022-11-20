using System.Threading.Tasks;
using Abp.Application.Services;
using ZeroToHero.Authorization.Accounts.Dto;

namespace ZeroToHero.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
