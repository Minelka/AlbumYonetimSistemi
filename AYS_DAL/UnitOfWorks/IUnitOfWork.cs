using AYS_DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS_DAL.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IAlbumRepository Albums { get; }
        IAdminRepository Admins { get; }
        int Complete();
    }
}
