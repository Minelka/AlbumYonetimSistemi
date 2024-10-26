using AutoMapper;
using AYS_DAL.Data;
using AYS_DAL.Entities.Concrete;
using AYS_DAL.Migrations;
using AYS_DAL.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS_DAL.Services.Concrete
{
    public class AlbumService<TModel> : Service<TModel, Album> where TModel : class
    {
        private IMapper _mapper;
        private readonly DB_AYSContext _aysDbContext;

        public AlbumService()
        {
            _aysDbContext = new DB_AYSContext();
            _repository = _unitOfWork.Albums;
        }
       
        public ICollection<Album> GetAllAlbums()
        {
            ICollection<Album> albums = _aysDbContext.Albums.ToList();

            return _mapper.Map<ICollection<Album>>(albums);
        }
        

    }
}
