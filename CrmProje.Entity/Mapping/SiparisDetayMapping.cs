using CrmProje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Mapping
{
    public class SiparisDetayMapping : EntityTypeConfiguration<SiparisDetay>
    {
        public SiparisDetayMapping()
        {
            ToTable("SiparisDetaylar");

            HasKey(sd => sd.ID);
            Property(sd => sd.BirimFiyati).HasColumnType("money");

            ///relationship

            HasRequired(sd => sd.Siparis).WithMany(s=>s.SiparisDetaylar).HasForeignKey(s=>s.SiparisID);
            HasRequired(sd => sd.Urun).WithMany(s => s.SiparisDetaylar).HasForeignKey(s => s.UrunID);

        }
    }
}
