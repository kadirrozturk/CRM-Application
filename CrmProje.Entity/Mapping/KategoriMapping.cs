using CrmProje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Mapping
{
    public class KategoriMapping : EntityTypeConfiguration<Kategori>
    {
        public KategoriMapping()
        {
            ToTable("Kategoriler");

            HasKey(k => k.ID);

            Property(k => k.Aciklama).HasColumnType("varchar").HasMaxLength(80);

            Property(k => k.KategoriAdi).HasColumnType("varchar").HasMaxLength(30).IsRequired();
        }
    }
}
