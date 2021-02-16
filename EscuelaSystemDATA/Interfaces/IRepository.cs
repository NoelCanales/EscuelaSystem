using EscuelaSystemModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EscuelaSystemDATA.Interfaces
{
   public interface IRepository<T> where T: IEntityTypeConfiguration
    {
        T GetById(int id);
        IEnumerable<T>List();

        IEnumerable<T>List(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Update(T entiry);
        void Delete(T entiry);
    }
}
