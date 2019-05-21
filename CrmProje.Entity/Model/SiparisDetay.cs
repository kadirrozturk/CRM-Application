using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Model
{
    public class SiparisDetay : IEntity
    {
        public int ID { get; set; }
        public int SiparisID { get; set; }
        public int UrunID { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyati { get; set; }
        public decimal Indirim { get; set; }
        

        //navigations
        public virtual Urun Urun { get; set; }
        public virtual Siparis Siparis { get; set; }

    }
}
