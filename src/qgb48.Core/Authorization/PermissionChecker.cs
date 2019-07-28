using Abp.Authorization;
using qgb48.Authorization.Roles;
using qgb48.Authorization.Users;

namespace qgb48.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
