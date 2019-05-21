using CrmProje.DAL.Repositories;
using CrmProje.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.BLL
{
    public class TedarikciIletisimDTOController
    {
        TedarikciIletisimDTORepository _dtoti;

        public TedarikciIletisimDTOController()
        {
            _dtoti = new TedarikciIletisimDTORepository();
        }
        public List<TedarikciIletisimDTO> DtoGetir()
        {
            return _dtoti.Get();
        }
    }
}
