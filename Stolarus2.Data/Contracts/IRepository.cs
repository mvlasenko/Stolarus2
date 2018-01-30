using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Stolarus2.Data.Contracts
{
    public interface IRepository<T, TKey> : IDisposable where T : IEntity<TKey>
    {
        T Delete(T entity);
        T GetById(TKey id);
        IPagedCollection GetPaged(IFilter<T, TKey> filter);
        ICollection<T> GetList();
        T Insert(T entity);
        T Update(T entity);
        DbContext GetContext();
        IQueryable<T> Query();
    }
}
