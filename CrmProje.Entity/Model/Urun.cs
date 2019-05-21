using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Model
{
    public class Urun : IEntity
    {
        public Urun()
        {
            SiparisDetaylar = new HashSet<SiparisDetay>();
        }
        public int ID { get; set; }
        public int KategoriID { get; set; }
        public string UrunAdi { get; set; }
        public decimal UrunFiyati { get; set; }
        public int StokAdeti { get; set; }
        public int TedarikciID { get; set; }
        public bool Durum { get; set; }

        //navigations
        public virtual Kategori Kategorisi { get; set; }
        public virtual Tedarikci Tedarikci { get; set; }
        public virtual ICollection<SiparisDetay> SiparisDetaylar { get; set; }


    }
}
