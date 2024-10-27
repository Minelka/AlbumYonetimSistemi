using AYS_DAL.Entities.Concrete;
using AYS_DAL.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace AYS_DAL.Repository.Concrete
    {
        // AdminRepository sınıfı, Admin varlıkları ile ilgili veri erişim işlemlerini yönetir.
        // Repository pattern'ını uygular ve IAdminRepository arayüzünü gerçekleştirir.
        public class AdminRepository : Repository<Admin>, IAdminRepository
        {
            private DbContext _dbcontext; // DbContext örneği, veri tabanı ile etkileşimde kullanılır.
            private bool disposed = false; // Dispose işlemi kontrolü için bayrak.

            // Constructor: Yeni bir AdminRepository örneği oluşturulduğunda DbContext başlatılır.
            public AdminRepository(DbContext context) : base(context)
            {
                _dbcontext = context; // Context atanır.
            }

            // Dispose metodu: Kaynakları serbest bırakmak için kullanılır.
            protected virtual void Dispose(bool disposing)
            {
                if (!this.disposed)
                {
                    if (disposing)
                    {
                        // Managed kaynakları serbest bırak.
                        _dbcontext.Dispose(); // DbContext'i dispose et.
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

