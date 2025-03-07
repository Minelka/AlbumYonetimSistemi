﻿using AutoMapper;
using AYS_BLL.Managers.Abstract;
using AYS_BLL.Models;
using AYS_DAL.Data;
using AYS_DAL.Entities.Concrete;
using AYS_DAL.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS_BLL.Managers.Concrete
{
    //Manager sınıfında bulunanları Album sınıfına göre özelleştirme işlemleri yapılır.
    public class AlbumManager : Manager<AlbumModel, AlbumService<AlbumModel>>
    {
        private readonly AlbumService<AlbumModel> _albumService;
        private IConfigurationProvider _config;
        private IMapper _mapper;

        public AlbumManager()
        {
            _albumService = new AlbumService<AlbumModel>();
            _config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Admin, AdminModel>();
                cfg.CreateMap<Album, AlbumModel>();

            });

            _mapper = new Mapper(_config);
        }

        //Tüm albümleri listeler
        public ICollection<AlbumModel> GetAllAlbums()
        {
            ICollection<AlbumModel> albums = _albumService.GetAll().Select(a => new AlbumModel
            {
                Id = a.Id,
                Name = a.Name,
                Artist = a.Artist,
                ReleaseDate = a.ReleaseDate,
                Price = a.Price,
                Discount = a.Discount,
                Status = a.Status
            }).ToList();

            return _mapper.Map<ICollection<AlbumModel>>(albums);
        }

        //Satılmayan albümleri listeler
        public ICollection<AlbumModel> GetUnsoldAlbums()
        {
            var unsoldAlbums = GetAllAlbums()
                                 .Where(a => a.Status == false)
                                 .Select(a => new AlbumModel
                                 {
                                     Name = a.Name,
                                     Artist = a.Artist
                                 }).ToList();

            return _mapper.Map<ICollection<AlbumModel>>(unsoldAlbums);
        }

        //Satışta olan albümleri listeler
        public ICollection<AlbumModel> GetSoldingAlbums()
        {
            var unsoldAlbums = GetAllAlbums()
                                 .Where(a => a.Status == true)
                                 .Select(a => new AlbumModel
                                 {
                                     Name = a.Name,
                                     Artist = a.Artist
                                 }).ToList();

            return _mapper.Map<ICollection<AlbumModel>>(unsoldAlbums);
        }

        //Son eklenen 10 albbümü listeler
        public ICollection<AlbumModel> GetLast10Albums()
        {
            var unsoldAlbums = GetAllAlbums()
                                 .Select(a => new AlbumModel
                                 {
                                     Name = a.Name,
                                     Artist = a.Artist
                                 })
                           .OrderByDescending(a => a.Created)
                           .Take(10)
                           .ToList();

            return _mapper.Map<ICollection<AlbumModel>>(unsoldAlbums);
        }

        //İndirimdeki albümleri listeler
        public ICollection<AlbumModel> GetDiscountedAlbums()
        {
            var unsoldAlbums = GetAllAlbums()
                                   .Where(a => a.Discount != 0)
                                   .Select(a => new AlbumModel
                                   {
                                       Name = a.Name,
                                       Artist = a.Artist,
                                       Discount = a.Discount
                                   })
                                   .OrderByDescending(a => a.Discount)
                                   .ToList();

            return _mapper.Map<ICollection<AlbumModel>>(unsoldAlbums);
        }
    }
}
