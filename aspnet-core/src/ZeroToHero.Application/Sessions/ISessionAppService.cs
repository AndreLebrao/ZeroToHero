using System.Threading.Tasks;
using Abp.Application.Services;
using ZeroToHero.Sessions.Dto;

namespace ZeroToHero.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
