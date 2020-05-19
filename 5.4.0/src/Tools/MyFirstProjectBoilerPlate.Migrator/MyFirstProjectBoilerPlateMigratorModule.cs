using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MyFirstProjectBoilerPlate.EntityFramework;

namespace MyFirstProjectBoilerPlate.Migrator
{
    [DependsOn(typeof(MyFirstProjectBoilerPlateDataModule))]
    public class MyFirstProjectBoilerPlateMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MyFirstProjectBoilerPlateDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}