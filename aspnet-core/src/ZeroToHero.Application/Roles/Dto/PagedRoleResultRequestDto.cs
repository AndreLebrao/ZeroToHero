using Abp.Application.Services.Dto;

namespace ZeroToHero.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

