using CrmProje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Mapping
{
    public class MusteriMapping : EntityTypeConfiguration<Musteri>
    {
        public MusteriMapping()
        {
            ToTable("Musteriler");
            HasKey(m => m.ID);
            Property(m => m.MusteriAdi).HasColumnType("varchar").HasMaxLength(40);
            Property(m => m.MusteriSoyadi).HasColumnType("varchar").HasMaxLength(40);
            Property(m => m.FirmaAdi).HasColumnType("varchar").HasMaxLength(70);
        }
    }
}
