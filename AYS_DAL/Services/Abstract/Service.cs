﻿using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using AYS_DAL.Data;
using AYS_DAL.Entities.Abstract;
using AYS_DAL.Repository.Abstract;
using AYS_DAL.UnitOfWorks;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IConfigurationProvider = AutoMapper.IConfigurationProvider;

namespace AYS_DAL.Services.Abstract
{
    public class Service<TModel, TEntity> : IDisposable, IService<TModel>
    where TModel : class
    where TEntity : BaseEntity
    {
        private protected readonly IUnitOfWork _unitOfWork;
        private protected IRepository<TEntity> _repository;
        private IConfigurationProvider _config;
        private IMapper _mapper;

        private bool disposed = false;

        public Service()
        {
            DB_AYSContext dB_AYSContext = new DB_AYSContext();

            _unitOfWork = new UnitOfWork (dB_AYSContext);

            _config = new MapperConfiguration(cfg => { cfg.AddExpressionMapping().CreateMap<TModel, TEntity>().ReverseMap(); });
            _mapper = new Mapper(_config);
        }

        public void Create(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Create(entity);
        }

        public void Update(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Update(entity);
        }

        public void Delete(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Delete(entity);
        }

        public ICollection<TModel> GetAll()
        {
            ICollection<TEntity> entities = _repository.GetAll();
            ICollection<TModel> models = _mapper.Map<ICollection<TModel>>(entities);

            return models;
        }

        public TModel GetById(int id)
        {
            TEntity entity = _repository.GetById(id);
            TModel model = _mapper.Map<TModel>(entity);

            return model;
        }

        public void Remove(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Remove(entity);
        }

        public int Save()
        {
            return _unitOfWork.Complete();
        }

        public ICollection<TModel> Search(Expression<Func<TModel, bool>> conditions)
        {
            Expression<Func<TEntity, bool>> expression = _mapper.Map<Expression<Func<TEntity, bool>>>(conditions);
            ICollection<TEntity> search = _repository.Search(expression);

            return _mapper.Map<ICollection<TModel>>(search);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _unitOfWork.Dispose();
                    _repository.Dispose();
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
