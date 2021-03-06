﻿using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Sgrc.EntityFramework.Repositories
{
    public abstract class SgrcRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SgrcDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SgrcRepositoryBase(IDbContextProvider<SgrcDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SgrcRepositoryBase<TEntity> : SgrcRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SgrcRepositoryBase(IDbContextProvider<SgrcDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
