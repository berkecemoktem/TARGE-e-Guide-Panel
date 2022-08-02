using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity, new() // Generic bir yapı gelecek , class olacak, newlenecek
    {
        // Ortak Crud işlemleri için oluşturulan bir interface.. 
        T Get(Expression<Func<T, bool>> filter = null);
        

        List<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
