using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using qgb48.Roles.Dto;
using qgb48.Users.Dto;

namespace qgb48.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
