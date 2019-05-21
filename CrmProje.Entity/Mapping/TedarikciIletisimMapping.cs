using CrmProje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Mapping
{
    public class TedarikciIletisimMapping:EntityTypeConfiguration<TedarikciIletisim>
    {
        public TedarikciIletisimMapping()
        {
            ToTable("TedarikciIletisimler");
            HasKey(ti => ti.ID);
            Property(ti => ti.Adress).HasColumnType("varchar").HasMaxLength(300);
            Property(ti => ti.Eposta).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            Property(ti => ti.Telefon).HasColumnType("char").HasMaxLength(10).IsFixedLength().IsRequired();

            ///relationship

            HasRequired(t => t.Tedarikci).WithMany(ti => ti.TedarikciIletisimler).HasForeignKey(t => t.TedarikciID);

        }
    }
}
