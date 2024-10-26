using AYS_DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS_DAL.Repository.Abstract
{
    public interface IAdminRepository : IRepository<Admin>, IDisposable
    {
    }
}
