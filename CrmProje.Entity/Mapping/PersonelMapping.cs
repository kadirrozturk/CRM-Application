using CrmProje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.Entity.Mapping
{
    public class PersonelMapping:EntityTypeConfiguration<Personel>
    {
        public PersonelMapping()
        {
            ToTable("Personeller");

            HasKey(p => p.ID);
            Property(p => p.PersonelAdi).HasColumnType("varchar").HasMaxLength(40);
            Property(p => p.PersonelSoyadi).HasColumnType("varchar").HasMaxLength(40);
            Property(p => p.DogumTarihi).HasColumnType("date");
            Property(p => p.IseGirisTarihi).HasColumnType("date");
            Property(p => p.TcNo).HasColumnType("char").HasMaxLength(11);
        }
    }
}
