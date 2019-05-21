using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.DTO
{
    public class MusteriIletisimDTO
    {
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public int MusteriID { get; set; }
        public string FirmaAdi { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }
        public string Adress { get; set; }
        public bool Durum { get; set; }

    }
}
