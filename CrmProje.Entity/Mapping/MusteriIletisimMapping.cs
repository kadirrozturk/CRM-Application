using CrmProje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Mapping
{
    public class MusteriIletisimMapping : EntityTypeConfiguration<MusteriIletisim>
    {
        public MusteriIletisimMapping()
        {
            ToTable("MusteriIletisim");
            HasKey(mi => mi.ID);
            Property(mi => mi.Adress).HasColumnType("varchar").HasMaxLength(300);
            Property(mi => mi.Eposta).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            Property(mi => mi.Telefon).HasColumnType("char").HasMaxLength(10).IsFixedLength().IsRequired();

            ///relationship

            HasRequired(m => m.Musteri).WithMany(mi => mi.MusteriIletisimler).HasForeignKey(m => m.MusteriID);


        }
    }
}
