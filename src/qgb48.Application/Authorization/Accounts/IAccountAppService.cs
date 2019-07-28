using System.Threading.Tasks;
using Abp.Application.Services;
using qgb48.Authorization.Accounts.Dto;

namespace qgb48.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
