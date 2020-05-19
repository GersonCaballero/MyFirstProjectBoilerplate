using Abp.MultiTenancy;
using MyFirstProjectBoilerPlate.Authorization.Users;

namespace MyFirstProjectBoilerPlate.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}