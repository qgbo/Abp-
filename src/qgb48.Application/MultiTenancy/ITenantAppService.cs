using Abp.Application.Services;
using Abp.Application.Services.Dto;
using qgb48.MultiTenancy.Dto;

namespace qgb48.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

