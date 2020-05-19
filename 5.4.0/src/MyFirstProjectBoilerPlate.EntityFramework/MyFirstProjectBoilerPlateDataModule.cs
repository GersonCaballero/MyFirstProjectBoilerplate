using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using MyFirstProjectBoilerPlate.EntityFramework;

namespace MyFirstProjectBoilerPlate
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(MyFirstProjectBoilerPlateCoreModule))]
    public class MyFirstProjectBoilerPlateDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MyFirstProjectBoilerPlateDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
