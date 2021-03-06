﻿using System.Data.Common;
using System.Data.Entity;
using Abp.DynamicEntityParameters;
using Abp.Zero.EntityFramework;
using MyFirstProjectBoilerPlate.Authorization.Roles;
using MyFirstProjectBoilerPlate.Authorization.Users;
using MyFirstProjectBoilerPlate.Employees;
using MyFirstProjectBoilerPlate.MultiTenancy;

namespace MyFirstProjectBoilerPlate.EntityFramework
{
    public class MyFirstProjectBoilerPlateDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public virtual IDbSet<Department> Departments { get; set; }
        public virtual IDbSet<Employee> Employees { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public MyFirstProjectBoilerPlateDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MyFirstProjectBoilerPlateDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MyFirstProjectBoilerPlateDbContext since ABP automatically handles it.
         */
        public MyFirstProjectBoilerPlateDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MyFirstProjectBoilerPlateDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MyFirstProjectBoilerPlateDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DynamicParameter>().Property(p => p.ParameterName).HasMaxLength(250);
            modelBuilder.Entity<EntityDynamicParameter>().Property(p => p.EntityFullName).HasMaxLength(250);
        }
    }
}
