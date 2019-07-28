using System.Threading.Tasks;
using Abp.Application.Services;
using qgb48.Sessions.Dto;

namespace qgb48.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
