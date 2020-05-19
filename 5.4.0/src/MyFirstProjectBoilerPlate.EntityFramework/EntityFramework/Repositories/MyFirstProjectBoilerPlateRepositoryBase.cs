using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MyFirstProjectBoilerPlate.EntityFramework.Repositories
{
    public abstract class MyFirstProjectBoilerPlateRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MyFirstProjectBoilerPlateDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MyFirstProjectBoilerPlateRepositoryBase(IDbContextProvider<MyFirstProjectBoilerPlateDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MyFirstProjectBoilerPlateRepositoryBase<TEntity> : MyFirstProjectBoilerPlateRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MyFirstProjectBoilerPlateRepositoryBase(IDbContextProvider<MyFirstProjectBoilerPlateDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
