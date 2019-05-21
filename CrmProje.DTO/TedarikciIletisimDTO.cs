using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.DTO
{
    public class TedarikciIletisimDTO
    {
        public string FirmaAdi { get; set; }
        public bool Durum { get; set; }
        public int TedarikciID { get; set; }
        public string Adress { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
    }
}
