namespace CrmProje.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrmProjeDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 30, unicode: false),
                        Aciklama = c.String(maxLength: 80, unicode: false),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KategoriID = c.Int(nullable: false),
                        UrunAdi = c.String(nullable: false, maxLength: 40, unicode: false),
                        UrunFiyati = c.Decimal(nullable: false, storeType: "money"),
                        StokAdeti = c.Int(nullable: false),
                        TedarikciID = c.Int(nullable: false),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriID, cascadeDelete: true)
                .ForeignKey("dbo.Tedarikciler", t => t.TedarikciID, cascadeDelete: true)
                .Index(t => t.KategoriID)
                .Index(t => t.TedarikciID);
            
            CreateTable(
                "dbo.SiparisDetaylar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SiparisID = c.Int(nullable: false),
                        UrunID = c.Int(nullable: false),
                        Adet = c.Int(nullable: false),
                        BirimFiyati = c.Decimal(nullable: false, storeType: "money"),
                        Indirim = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Siparisler", t => t.SiparisID, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunID, cascadeDelete: true)
                .Index(t => t.SiparisID)
                .Index(t => t.UrunID);
            
            CreateTable(
                "dbo.Siparisler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PersonelID = c.Int(nullable: false),
                        MusteriID = c.Int(nullable: false),
                        SiparisTarihi = c.DateTime(nullable: false),
                        OdemeTarihi = c.DateTime(nullable: false),
                        SevkTarihi = c.DateTime(nullable: false),
                        SevkAdresi = c.String(maxLength: 80, unicode: false),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Musteriler", t => t.MusteriID, cascadeDelete: true)
                .ForeignKey("dbo.Personeller", t => t.PersonelID, cascadeDelete: true)
                .Index(t => t.PersonelID)
                .Index(t => t.MusteriID);
            
            CreateTable(
                "dbo.Musteriler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MusteriAdi = c.String(maxLength: 40, unicode: false),
                        MusteriSoyadi = c.String(maxLength: 40, unicode: false),
                        Cinsiyet = c.String(),
                        FirmaAdi = c.String(maxLength: 70, unicode: false),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MusteriIletisim",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MusteriID = c.Int(nullable: false),
                        Adress = c.String(maxLength: 300, unicode: false),
                        Telefon = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Eposta = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Musteriler", t => t.MusteriID, cascadeDelete: true)
                .Index(t => t.MusteriID);
            
            CreateTable(
                "dbo.Personeller",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PersonelAdi = c.String(maxLength: 40, unicode: false),
                        PersonelSoyadi = c.String(maxLength: 40, unicode: false),
                        Cinsiyet = c.String(),
                        TcNo = c.String(maxLength: 11, fixedLength: true, unicode: false),
                        Email = c.String(),
                        Sifre = c.String(),
                        DogumTarihi = c.DateTime(nullable: false, storeType: "date"),
                        IseGirisTarihi = c.DateTime(nullable: false, storeType: "date"),
                        isAdminMi = c.Boolean(nullable: false),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tedarikciler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirmaAdi = c.String(maxLength: 30, unicode: false),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TedarikciIletisimler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TedarikciID = c.Int(nullable: false),
                        Adress = c.String(maxLength: 300, unicode: false),
                        Telefon = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Eposta = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tedarikciler", t => t.TedarikciID, cascadeDelete: true)
                .Index(t => t.TedarikciID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urunler", "TedarikciID", "dbo.Tedarikciler");
            DropForeignKey("dbo.TedarikciIletisimler", "TedarikciID", "dbo.Tedarikciler");
            DropForeignKey("dbo.SiparisDetaylar", "UrunID", "dbo.Urunler");
            DropForeignKey("dbo.SiparisDetaylar", "SiparisID", "dbo.Siparisler");
            DropForeignKey("dbo.Siparisler", "PersonelID", "dbo.Personeller");
            DropForeignKey("dbo.Siparisler", "MusteriID", "dbo.Musteriler");
            DropForeignKey("dbo.MusteriIletisim", "MusteriID", "dbo.Musteriler");
            DropForeignKey("dbo.Urunler", "KategoriID", "dbo.Kategoriler");
            DropIndex("dbo.TedarikciIletisimler", new[] { "TedarikciID" });
            DropIndex("dbo.MusteriIletisim", new[] { "MusteriID" });
            DropIndex("dbo.Siparisler", new[] { "MusteriID" });
            DropIndex("dbo.Siparisler", new[] { "PersonelID" });
            DropIndex("dbo.SiparisDetaylar", new[] { "UrunID" });
            DropIndex("dbo.SiparisDetaylar", new[] { "SiparisID" });
            DropIndex("dbo.Urunler", new[] { "TedarikciID" });
            DropIndex("dbo.Urunler", new[] { "KategoriID" });
            DropTable("dbo.TedarikciIletisimler");
            DropTable("dbo.Tedarikciler");
            DropTable("dbo.Personeller");
            DropTable("dbo.MusteriIletisim");
            DropTable("dbo.Musteriler");
            DropTable("dbo.Siparisler");
            DropTable("dbo.SiparisDetaylar");
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategoriler");
        }
    }
}
