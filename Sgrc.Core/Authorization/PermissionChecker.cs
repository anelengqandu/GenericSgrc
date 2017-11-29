using Abp.Authorization;
using Sgrc.Authorization.Roles;
using Sgrc.Authorization.Users;

namespace Sgrc.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
