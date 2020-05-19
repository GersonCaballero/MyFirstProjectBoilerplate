using System.Linq;
using MyFirstProjectBoilerPlate.EntityFramework;
using MyFirstProjectBoilerPlate.MultiTenancy;

namespace MyFirstProjectBoilerPlate.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MyFirstProjectBoilerPlateDbContext _context;

        public DefaultTenantCreator(MyFirstProjectBoilerPlateDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
