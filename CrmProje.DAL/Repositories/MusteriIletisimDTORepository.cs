using CrmProje.DAL.IRepositories;
using CrmProje.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.IBaseRepositories;
using System.Linq.Expressions;

namespace CrmProje.DAL.Repositories
{
    public class MusteriIletisimDTORepository : IGetExp<MusteriIletisimDTO>
    {
        CrmDBContext _db;
        public MusteriIletisimDTORepository()
        {
            _db = new CrmDBContext();
        }
        public List<MusteriIletisimDTO> Get(Expression<Func<MusteriIletisimDTO, bool>> exp = null)
        {
            var sorgu = (from m in _db.Musteriler
                         join mi in _db.MusteriIletisimler
                         on m.ID equals mi.MusteriID
                         select new MusteriIletisimDTO()
        {
            MusteriAdi = m.MusteriAdi,
            MusteriSoyadi = m.MusteriSoyadi,
            FirmaAdi = m.FirmaAdi,
            Telefon = mi.Telefon,
            Eposta = mi.Eposta,
            Adress = mi.Adress,
            Durum = m.Durum,
            MusteriID=m.ID,

        });
            if (exp == null)
            {
                return sorgu.ToList();
            }
            else
            {
                return sorgu.Where(exp).ToList();
            }
        }
    }
}

