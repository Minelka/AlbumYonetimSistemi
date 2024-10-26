using AYS_BLL.Managers.Abstract;
using AYS_BLL.Models;
using AYS_DAL.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS_BLL.Managers.Concrete
{
    public class AdminManager : Manager<AdminModel, AdminService<AdminModel>>
    {
    }
}
