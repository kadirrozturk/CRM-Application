using CrmProje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Mapping
{
    public class UrunMapping:EntityTypeConfiguration<Urun>
    {
        public UrunMapping()
        {
            ToTable("Urunler");

            HasKey(u => u.ID);
            Property(u => u.UrunAdi).HasColumnType("varchar").HasMaxLength(40).IsRequired();
            Property(u => u.UrunFiyati).HasColumnType("money");

            //relationship
            HasRequired(u => u.Kategorisi).WithMany(k => k.Urunleri).HasForeignKey(u => u.KategoriID);
            HasRequired(u => u.Tedarikci).WithMany(u => u.Urunleri).HasForeignKey(u => u.TedarikciID);
        }
    }
}
