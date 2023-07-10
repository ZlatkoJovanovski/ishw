﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ishw.Domain.DomainModels;
using ishw.Repository.Interface;
using is_hw.Data;

namespace ishw.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly ApplicationDbContext context;
        private DbSet<T> entities;
        string erorMessage = string.Empty;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public T Get(int id)
        {
            return entities.SingleOrDefault(z => z.Id == id);
        }

        public IEnumerable<T> All => entities.AsEnumerable();

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}