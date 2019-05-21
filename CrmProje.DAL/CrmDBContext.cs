using CrmProje.Entity.Mapping;
using CrmProje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.DAL
{
    public class CrmDBContext : DbContext
    {
        public CrmDBContext()
            : base("Server=.;Database=CrmProjeDB;Trusted_Connection=true")
        {

        }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylar { get; set; }
        public DbSet<MusteriIletisim> MusteriIletisimler { get; set; }
        public DbSet<TedarikciIletisim> TedarikciIletisimler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KategoriMapping());
            modelBuilder.Configurations.Add(new UrunMapping());
            modelBuilder.Configurations.Add(new PersonelMapping());
            modelBuilder.Configurations.Add(new TedarikciMapping());
            modelBuilder.Configurations.Add(new TedarikciIletisimMapping());
            modelBuilder.Configurations.Add(new MusteriMapping());
            modelBuilder.Configurations.Add(new MusteriIletisimMapping());
            modelBuilder.Configurations.Add(new SiparisDetayMapping());
            modelBuilder.Configurations.Add(new SiparisMapping());

            base.OnModelCreating(modelBuilder);
        }

    }
}
