using OtelRezarvasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        // tüm metotlar tanımlanması.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
