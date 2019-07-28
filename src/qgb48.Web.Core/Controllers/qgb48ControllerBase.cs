using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace qgb48.Controllers
{
    public abstract class qgb48ControllerBase: AbpController
    {
        protected qgb48ControllerBase()
        {
            LocalizationSourceName = qgb48Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
