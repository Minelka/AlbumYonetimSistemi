﻿using AYS_DAL.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AYS_DAL.Repository.Abstract
{
    public class Repository<TEntity> : IRepository<TEntity>, IDisposable where TEntity : BaseEntity
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _entities;
        private bool disposed = false;

        protected Repository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }
        // Yeni bir varlık oluşturur ve veritabanına ekler.
        public void Create(TEntity entity)
        {
            entity.IsActive = true;
            _entities.Add(entity);
        }

        // Mevcut bir varlığı günceller.
        public void Update(TEntity entity)
        {
            var existingEntity = GetById(entity.Id);

            if (existingEntity != null)
            {
               
                entity.Created = existingEntity.Created;
            }
            else
            {
                entity.Created = DateTime.Now; 
            }

            entity.Modified = DateTime.Now;
            entity.IsActive = true;

            _entities.Update(entity);
        }
        //Varlığı siler (soft delete).
        public void Delete(TEntity entity)
        {
            entity.Deleted = DateTime.Now;
            entity.IsActive = false;
            Update(entity);
        }

        // Tüm varlıkları getirir.
        public ICollection<TEntity> GetAll()
        {
            return _entities.AsNoTracking().Where(e => e.Deleted == null).ToList();
        }

        // Belirli bir ID'ye sahip varlığı getirir.
        public TEntity GetById(int id)
        {
            return _entities.AsNoTracking().SingleOrDefault(e => e.Id == id);
        }

        // Varlığı veritabanından kalıcı olarak siler.
        public void Remove(TEntity entity)
        {
            _entities.Remove(entity);
        }

        // Belirli koşullara göre varlıkları arar.
        public ICollection<TEntity> Search(Expression<Func<TEntity, bool>> conditions)
        {
            return _entities.AsNoTracking().Where(e => e.Deleted == null).Where(conditions.Compile()).ToList();
        }

        // Kullanılan kaynakları serbest bırakır.
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
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
