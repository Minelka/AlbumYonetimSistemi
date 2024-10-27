using AYS_DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AYS_DAL.UnitOfWorks
{
    // IUnitOfWork arayüzü, birim iş mantığını tanımlar ve repository'leri yönetir.
    // Aynı zamanda kaynakların serbest bırakılmasını sağlamak için IDisposable arayüzünü uygular.
    public interface IUnitOfWork : IDisposable
    {
        // Albums özelliği: IAlbumRepository nesnesine erişim sağlar.
        IAlbumRepository Albums { get; }

        // Admins özelliği: IAdminRepository nesnesine erişim sağlar.
        IAdminRepository Admins { get; }

        // Complete metodu: Yapılan değişiklikleri veri tabanına kaydeder ve etkilenen satır sayısını döner.
        int Complete();
    }
}

