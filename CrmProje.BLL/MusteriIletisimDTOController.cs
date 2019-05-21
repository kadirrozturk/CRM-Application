using CrmProje.DAL.Repositories;
using CrmProje.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.BLL
{
    public class MusteriIletisimDTOController 
    {
        MusteriIletisimDTORepository _dtomi;
        public MusteriIletisimDTOController()
        {
            _dtomi = new MusteriIletisimDTORepository();
        }

        public List<MusteriIletisimDTO> DtoGetir()
        {
            return _dtomi.Get();
        }
    }
}
