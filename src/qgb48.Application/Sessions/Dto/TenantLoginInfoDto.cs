using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using qgb48.MultiTenancy;

namespace qgb48.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
