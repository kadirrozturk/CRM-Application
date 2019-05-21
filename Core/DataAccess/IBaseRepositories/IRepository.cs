using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.IBaseRepositories
{
    public interface IRepository<TEntity, TKey>
        : IAdd<TEntity>
        , IDelete<TEntity>
        , IDeleteById<TKey>
        , IDeleteExp<TEntity>
        , IGetExp<TEntity>
        , ISave
        , IUpdate<TEntity>
        , IGetById<TEntity, TKey>
        where TEntity : class,IEntity, new()
    {
    }
}
