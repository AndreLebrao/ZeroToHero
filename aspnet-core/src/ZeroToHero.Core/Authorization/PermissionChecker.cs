using Abp.Authorization;
using ZeroToHero.Authorization.Roles;
using ZeroToHero.Authorization.Users;

namespace ZeroToHero.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
