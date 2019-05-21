using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.IBaseRepositories
{
    public interface IGetExp<T> where T:class,new()
    {
        List<T> Get(Expression<Func<T, bool>> exp = null);
    }
}
