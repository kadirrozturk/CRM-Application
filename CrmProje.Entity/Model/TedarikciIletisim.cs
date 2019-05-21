using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Model
{
    public class TedarikciIletisim : IEntity
    {
        public int ID { get; set; }
        public int TedarikciID { get; set; }
        public string Adress { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        
        //navigations

        public virtual  Tedarikci Tedarikci { get; set; }

    }
}
