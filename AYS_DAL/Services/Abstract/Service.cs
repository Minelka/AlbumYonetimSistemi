using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using AYS_DAL.Data;
using AYS_DAL.Entities.Abstract;
using AYS_DAL.Repository.Abstract;
using AYS_DAL.UnitOfWorks;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IConfigurationProvider = AutoMapper.IConfigurationProvider;

namespace AYS_DAL.Services.Abstract
{
    // Service sınıfı, genel bir hizmet katmanı sağlar.
    // Bu sınıf, model ve varlık arasındaki dönüşümü yönetir.
    public class Service<TModel, TEntity> : IDisposable, IService<TModel>
        where TModel : class
        where TEntity : BaseEntity
    {
        private protected readonly IUnitOfWork _unitOfWork; // UnitOfWork örneği, veri tabanı işlemlerini yönetir.
        private protected IRepository<TEntity> _repository; // Repository örneği, veritabanı işlemleri için kullanılır.
        private IConfigurationProvider _config; // AutoMapper konfigürasyonu.
        private IMapper _mapper; // AutoMapper örneği, dönüşümler için kullanılır.

        private bool disposed = false; // Dispose işlemi kontrolü için bayrak.

        // Constructor: Yeni bir Service örneği oluşturulduğunda gerekli bileşenler başlatılır.
        public Service()
        {
            DB_AYSContext dB_AYSContext = new DB_AYSContext(); // Veri tabanı bağlamı oluşturulur.
            _unitOfWork = new UnitOfWork(dB_AYSContext); // UnitOfWork başlatılır.

            // AutoMapper konfigürasyonu: TModel ile TEntity arasında çift yönlü dönüşüm oluşturulur.
            _config = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping().CreateMap<TModel, TEntity>().ReverseMap();
            });
            _mapper = new Mapper(_config); // AutoMapper nesnesi oluşturulur.
        }

        // Yeni bir model oluşturur ve veritabanına ekler.
        public void Create(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model); // Modelden varlığa dönüşüm yapılır.
            _repository.Create(entity); // Varlık eklenir.
        }

        // Mevcut bir modeli günceller.
        public void Update(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model); // Modelden varlığa dönüşüm yapılır.
            _repository.Update(entity); // Varlık güncellenir.
        }

        // Mevcut bir modeli siler.
        public void Delete(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model); // Modelden varlığa dönüşüm yapılır.
            _repository.Delete(entity); // Varlık silinir.
        }

        // Tüm modelleri alır.
        public ICollection<TModel> GetAll()
        {
            ICollection<TEntity> entities = _repository.GetAll(); // Tüm varlıkları alır.
            ICollection<TModel> models = _mapper.Map<ICollection<TModel>>(entities); // Varlıklardan modellere dönüşüm yapılır.

            return models; // Modeller döner.
        }

        // ID'sine göre bir modeli alır.
        public TModel GetById(int id)
        {
            TEntity entity = _repository.GetById(id); // Varlık ID'sine göre alınır.
            TModel model = _mapper.Map<TModel>(entity); // Varlıktan modele dönüşüm yapılır.

            return model; // Model döner.
        }

        // Mevcut bir modeli kaldırır.
        public void Remove(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model); // Modelden varlığa dönüşüm yapılır.
            _repository.Remove(entity); // Varlık kaldırılır.
        }

        // Değişiklikleri kaydeder ve etkilenen satır sayısını döner.
        public int Save()
        {
            return _unitOfWork.Complete(); // UnitOfWork üzerinden kaydetme işlemi yapılır.
        }

        // Belirtilen koşullara göre arama yapar.
        public ICollection<TModel> Search(Expression<Func<TModel, bool>> conditions)
        {
            Expression<Func<TEntity, bool>> expression = _mapper.Map<Expression<Func<TEntity, bool>>>(conditions); // Koşul ifadesi varlığa dönüştürülür.
            ICollection<TEntity> search = _repository.Search(expression); // Repository üzerinden arama yapılır.

            return _mapper.Map<ICollection<TModel>>(search); // Varlıklardan modellere dönüşüm yapılır ve döner.
        }

        // Dispose metodu: Kaynakları serbest bırakmak için kullanılır.
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    // Managed kaynakları serbest bırak.
                    _unitOfWork.Dispose(); // UnitOfWork serbest bırakılır.
                    _repository.Dispose(); // Repository serbest bırakılır.
                }
            }
            this.disposed = true; // Dispose işlemi yapıldığını işaretle.
        }

        // IDisposable arayüzünden gelen Dispose metodu.
        public void Dispose()
        {
            Dispose(true); // Dispose işlemini çağır.
            GC.SuppressFinalize(this); // Çöp toplayıcıya, nesnenin sonlandırıcısını çağırmaması için bildirimde bulun.
        }
    }
}
