using AutoMapper;
using Abp.Authorization;
using Abp.Authorization.Roles;
using qgb48.Authorization.Roles;

namespace qgb48.Roles.Dto
{
    public class RoleMapProfile : Profile
    {
        public RoleMapProfile()
        {
            // Role and permission
            CreateMap<Permission, string>().ConvertUsing(r => r.Name);
            CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);

            CreateMap<CreateRoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
            CreateMap<RoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
        }
    }
}
