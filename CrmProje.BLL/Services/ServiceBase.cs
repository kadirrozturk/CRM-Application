using Core.DataAccess.IBaseRepositories;
using Core.Entities;
using CrmProje.BLL.IServices.IBaseServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.BLL.Services
{
    public class ServiceBase<TEntity,TKey>:IService<TEntity,TKey> where TEntity:class,IEntity,new()
    {
        IRepository<TEntity, TKey> _repository;
        public ServiceBase(IRepository<TEntity,TKey> repository)
        {
            _repository = repository;
        }


        public List<TEntity> Getir(Expression<Func<TEntity, bool>> exp = null)
        {
            return _repository.Get(exp);
        }

        public TEntity Getir(TKey id)
        {
            return _repository.GetById(id);
        }

        public string Guncelle(TEntity entity)
        {
            try
            {
                _repository.Update(entity);
                return "Güncelleme Başarıyla Tamamlandı.";
            }
            catch (Exception e)
            {
                return "Bir hata nedeniyle güncelleme yapılamamıştır. Hata:" + e.Message;
            }
        }

        public string Ekle(TEntity entity)
        {
            try
            {
                _repository.Add(entity);
                return "Kayıt işlemi başarı ile tamamlanmıştır";
            }
            catch (Exception)
            {
                return "Bir hata nedeniyle kayıt işlemi yapılamamıştır.";
            }
        }
    }
}
