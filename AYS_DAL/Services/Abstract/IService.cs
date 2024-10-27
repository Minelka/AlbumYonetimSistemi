using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AYS_DAL.Services.Abstract
{
    // IService arayüzü, hizmet katmanındaki genel işlevselliği tanımlar.
    // IDisposable arayüzünü uygulayarak kaynak yönetimi sağlar.
    public interface IService<TModel> : IDisposable where TModel : class
    {
        // Yeni bir model oluşturur ve veritabanına ekler.
        public void Create(TModel model);

        // Mevcut bir modeli günceller.
        public void Update(TModel model);

        // Mevcut bir modeli siler.
        public void Delete(TModel model);

        // Mevcut bir modeli kaldırır (silme işlemi yerine geçer).
        public void Remove(TModel model);

        // Tüm modelleri alır.
        public ICollection<TModel> GetAll();

        // ID'sine göre bir modeli alır.
        public TModel GetById(int id);

        // Belirtilen koşullara göre arama yapar.
        public ICollection<TModel> Search(Expression<Func<TModel, bool>> conditions);

        // Değişiklikleri kaydeder ve etkilenen satır sayısını döner.
        int Save();
    }
}
