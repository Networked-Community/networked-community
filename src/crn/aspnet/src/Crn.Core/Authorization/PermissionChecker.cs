using Abp.Authorization;
using Crn.Authorization.Roles;
using Crn.Authorization.Users;

namespace Crn.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
