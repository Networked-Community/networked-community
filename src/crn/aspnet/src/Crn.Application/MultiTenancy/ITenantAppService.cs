using Abp.Application.Services;
using Crn.MultiTenancy.Dto;

namespace Crn.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

