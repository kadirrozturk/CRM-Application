using Core.DataAccess.BaseClasses.EntityFramework;
using CrmProje.DAL.IRepositories;
using CrmProje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.DAL.Repositories
{
    public class UrunRepository : EFRepositoryBase<Urun, int, CrmDBContext>, IUrunRepository
    {
        public UrunRepository()
            : base(new CrmDBContext())
        {

        }
    }
}
