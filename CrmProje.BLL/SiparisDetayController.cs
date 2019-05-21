using CrmProje.BLL.IServices;
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
    public class SiparisDetayController : ServiceBase<SiparisDetay, int>, ISiparisDetayService
    {
        public SiparisDetayController()
            : base(new SiparisDetayRepository())
        {

        }
    }
}
