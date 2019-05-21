using Core.DataAccess.IBaseRepositories;
using CrmProje.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace CrmProje.DAL.Repositories
{
    public class TedarikciIletisimDTORepository : IGetExp<TedarikciIletisimDTO>
    {
        CrmDBContext _db;
        public TedarikciIletisimDTORepository()
        {
            _db = new CrmDBContext();
        }

        public List<TedarikciIletisimDTO> Get(Expression<Func<TedarikciIletisimDTO, bool>> exp = null)
        {
            var sorgu = (from t in _db.Tedarikciler
                         join ti in _db.TedarikciIletisimler
                         on t.ID equals ti.TedarikciID
                         select new TedarikciIletisimDTO()
        {
            FirmaAdi = t.FirmaAdi,
            Telefon = ti.Telefon,
            Eposta = ti.Eposta,
            Adress = ti.Adress,
            Durum = t.Durum,
            TedarikciID = t.ID,

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

