using CrmProje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Mapping
{
    public class TedarikciMapping:EntityTypeConfiguration<Tedarikci>
    {
        public TedarikciMapping()
        {
            ToTable("Tedarikciler");

            HasKey(t => t.ID);
            Property(t => t.FirmaAdi).HasColumnType("varchar").HasMaxLength(30);

        }
    }
}
