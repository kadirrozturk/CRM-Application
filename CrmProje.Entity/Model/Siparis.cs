using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Model
{
    public class Siparis : IEntity
    {
        public int ID { get; set; }
        public int PersonelID { get; set; }
        public int MusteriID { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public DateTime SevkTarihi { get; set; }
        public string SevkAdresi { get; set; }
        public bool Durum { get; set; }


        //navigations
        public virtual Musteri Musteri { get; set; }
        public virtual Personel Personel { get; set; }
        public virtual ICollection<SiparisDetay> SiparisDetaylar { get; set; }



    }
}
