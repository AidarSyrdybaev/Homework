using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using HomeWorkApplication.DAL.Entities;
using HomeWorkApplication.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;


namespace HomeWorkApplication.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, Entity
    {
        protected ApplicationDbContext _applicationContext;

        protected DbSet<T> entities;

        public Repository(ApplicationDbContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public T Create(T entity)
        {
            var EntityEntry = entities.Add(entity);
            _applicationContext.SaveChanges();
            return EntityEntry.Entity;
        }

        public IEnumerable<T> GetAll()
        {
            return entities;
        }

        public T GetById(int id)
        {
            var Entity = entities.FirstOrDefault(i => i.Id == id);
            return Entity;
        }

        public void Remove(T entity)
        {
            entities.Remove(entity);
            _applicationContext.SaveChanges();
        }

        public T Update(T entity)
        {
            var EntityEntry = entities.Update(entity);
            _applicationContext.SaveChanges();
            return EntityEntry.Entity;
        }
    }
}
