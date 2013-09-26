using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Thing.Data.Interfaces
{
  public interface IRepository<T> : IDisposable where T: class
  {
    T Get(int id);
    IEnumerable<T> Get();
    T First();
    T First(Expression<Func<T, bool>> where);
    IEnumerable<T> Where(Expression<Func<T, bool>> where);
    T Add(T entity);
    void Delete(T entity);
    void Delete(IEnumerable<T> entities);
  }
}
