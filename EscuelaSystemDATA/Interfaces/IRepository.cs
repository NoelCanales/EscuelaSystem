using EscuelaSystemModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EscuelaSystemDATA.Interfaces
{
   public interface IRepository<T> where T: EntityBase
    {
        T GetById(int id);
        IEnumerable<T>list();

        IEnumerable<T>list(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Update(T entiry);
        void Delete(T entiry);
    }
}
