using Abp.Authorization;
using Opera.Authorization.Roles;
using Opera.Authorization.Users;

namespace Opera.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
