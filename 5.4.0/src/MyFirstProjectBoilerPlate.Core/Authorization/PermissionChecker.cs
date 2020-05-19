using Abp.Authorization;
using MyFirstProjectBoilerPlate.Authorization.Roles;
using MyFirstProjectBoilerPlate.Authorization.Users;

namespace MyFirstProjectBoilerPlate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
