using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Model
{
    public class Tedarikci : IEntity
    {
        public Tedarikci()
        {
            Urunleri = new HashSet<Urun>();
            TedarikciIletisimler = new HashSet<TedarikciIletisim>();
        }
        public int ID { get; set; }
        public string FirmaAdi { get; set; }
        public bool Durum { get; set; }

        //navigations
        public virtual ICollection<Urun> Urunleri { get; set; }
        public virtual ICollection<TedarikciIletisim> TedarikciIletisimler { get; set; }

    }
}
