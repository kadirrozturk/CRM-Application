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
    public class SiparisDetayRepository : EFRepositoryBase<SiparisDetay, int, CrmDBContext>, ISiparisDetayRepository
    {
        public SiparisDetayRepository()
            : base(new CrmDBContext())
        {

        }
    }
}
