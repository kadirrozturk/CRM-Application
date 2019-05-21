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
    public class MusteriIletisimRepository : EFRepositoryBase<MusteriIletisim, int, CrmDBContext>, IMusteriIletisimRepository
    {
        public MusteriIletisimRepository()
            : base(new CrmDBContext())
        {

        }
    }
}
