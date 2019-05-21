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
    public class PersonelRepository : EFRepositoryBase<Personel, int, CrmDBContext>, IPersonelRepository
    {
        public PersonelRepository()
            : base(new CrmDBContext())
        {

        }
    }
}
