using Abp.Application.Services;
using ZeroToHero.MultiTenancy.Dto;

namespace ZeroToHero.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

