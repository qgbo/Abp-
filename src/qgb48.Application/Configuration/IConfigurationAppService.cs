using System.Threading.Tasks;
using qgb48.Configuration.Dto;

namespace qgb48.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
