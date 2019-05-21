using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Model
{
    public class Kategori : IEntity 
    {
        public Kategori()
        {
            Urunleri = new HashSet<Urun>();
        }
        public int ID { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }

        //navigations
        public virtual ICollection<Urun> Urunleri { get; set; }
        
    }
}
