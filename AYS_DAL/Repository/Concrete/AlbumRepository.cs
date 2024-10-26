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

    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        private DbContext _dbcontext;
        private bool disposed = false;
        public AlbumRepository(DbContext context) : base(context)
        {
            _dbcontext = context;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbcontext.Dispose();
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
