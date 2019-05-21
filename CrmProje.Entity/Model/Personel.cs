using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Model
{
    public class Personel : IEntity
    {
        public Personel()
        {
            Siparisler = new HashSet<Siparis>();
        }
        public int ID { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public string Cinsiyet { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public bool isAdminMi { get; set; }
        public bool Durum { get; set; }
        
        //navigations
        public virtual ICollection<Siparis> Siparisler { get; set; }

    }
}
