using AutoMapper;
using AYS_BLL.Managers.Abstract;
using AYS_BLL.Models;
using AYS_DAL.Data;
using AYS_DAL.Entities.Concrete;
using AYS_DAL.Services.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS_BLL.Managers.Concrete
{
    public class AdminManager : Manager<AdminModel, AdminService<AdminModel>>
    {
        private IMapper _mapper;
        private readonly DB_AYSContext _DbContext;

        public AdminManager()
        {
            _DbContext = new DB_AYSContext();
        }
        public ICollection<Admin> UserGetAll()
        {
            return _DbContext.Admins.ToList();
        }

        public ICollection<AdminModel> GetAllUsers()
        {
            ICollection<Admin> admins = UserGetAll();

            return _mapper.Map<ICollection<AdminModel>>(admins);
        }
    }
}
