using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Model
{
    public class Musteri : IEntity
    {
        public Musteri()
        {
            Siparisler = new HashSet<Siparis>();
            MusteriIletisimler = new HashSet<MusteriIletisim>();
        }
        public int ID { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string Cinsiyet { get; set; }
        public string FirmaAdi { get; set; }
        public bool Durum { get; set; }


        //navigations
        public virtual ICollection<Siparis> Siparisler { get; set; }
        public virtual ICollection<MusteriIletisim> MusteriIletisimler { get; set; }


    }
}
