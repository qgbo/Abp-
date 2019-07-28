using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using qgb48.Configuration.Dto;

namespace qgb48.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : qgb48AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
