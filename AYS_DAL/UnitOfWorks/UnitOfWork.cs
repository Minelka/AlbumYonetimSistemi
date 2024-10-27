using AYS_DAL.Repository.Abstract;
using AYS_DAL.Repository.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS_DAL.UnitOfWorks
{
    // UnitOfWork sınıfı, veri erişim katmanında birimi temsil eder.
    // Birden fazla repository'yi yönetir ve veri bütünlüğünü sağlar.
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _dbcontext;
        private bool disposed = false;

        public UnitOfWork(DbContext context)
        {
            _dbcontext = context;

            Admins = new AdminRepository(_dbcontext);

            Albums = new AlbumRepository(_dbcontext);

        }


        public IAlbumRepository Albums { get; private set; }

        public IAdminRepository Admins { get; private set; }

        public int Complete()
        {
            int affectedRows = _dbcontext.SaveChanges();

            return affectedRows;
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbcontext.Dispose();
                    Admins.Dispose();
                    Albums.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
