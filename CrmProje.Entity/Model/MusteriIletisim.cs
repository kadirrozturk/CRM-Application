using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Model
{
    public class MusteriIletisim : IEntity
    {
        public int ID { get; set; }
        public int MusteriID { get; set; }
        public string Adress { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }

        //navigations
        public Musteri Musteri { get; set; }


    }
}
