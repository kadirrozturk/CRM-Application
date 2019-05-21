using CrmProje.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Mapping
{
    public class SiparisMapping : EntityTypeConfiguration<Siparis>
    {
        public SiparisMapping()
        {
            ToTable("Siparisler");

            HasKey(s => s.ID);
            Property(s => s.SevkAdresi).HasColumnType("varchar").HasMaxLength(80);

            //relationship

            HasRequired(s => s.Musteri).WithMany(m => m.Siparisler).HasForeignKey(m => m.MusteriID);
            HasRequired(s => s.Personel).WithMany(p => p.Siparisler).HasForeignKey(s => s.PersonelID);
        }
    }
}
