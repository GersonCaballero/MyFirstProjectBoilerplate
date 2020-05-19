using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using MyFirstProjectBoilerPlate.EntityFramework;

namespace MyFirstProjectBoilerPlate.Migrations
{
    public class AbpZeroDbMigrator : AbpZeroDbMigrator<MyFirstProjectBoilerPlateDbContext, Configuration>
    {
        public AbpZeroDbMigrator(
            IUnitOfWorkManager unitOfWorkManager,
            IDbPerTenantConnectionStringResolver connectionStringResolver,
            IIocResolver iocResolver)
            : base(
                unitOfWorkManager,
                connectionStringResolver,
                iocResolver)
        {
        }
    }
}
