using EscuelaSystemDATA.Interfaces;
using EscuelaSystemModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EscuelaSystemDATA
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly ApplicationDbContext dbContext;

        public Repository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public virtual T GetById(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

       
        public virtual IEnumerable<T> list()
        {
            return dbContext.Set<T>().AsEnumerable();
        }

        public virtual IEnumerable<T> list(Expression<Func<T, bool>> predicate)
        {
            return dbContext.Set<T>()
                .Where(predicate)
                .AsEnumerable();
        }

        public void Insert(T entity)
        {
            dbContext.Set<T>().Add(entity);
            dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            dbContext.SaveChanges();
        }

    }
}
