using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.IBaseRepositories
{
    public interface IDeleteExp<TEntity> where TEntity : class,IEntity, new()
    {
        int Delete(Expression<Func<TEntity, bool>> exp);
    }
}
