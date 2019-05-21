using CrmProje.BLL.IServices.IBaseServices;
using CrmProje.BLL.Services;
using CrmProje.DAL.Repositories;
using CrmProje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.BLL
{
    public class MusteriController : ServiceBase<Musteri, int>, IMusteriService
    {
        public MusteriController()
            : base(new MusteriRepository())
        {

        }
       
   
    }
}
