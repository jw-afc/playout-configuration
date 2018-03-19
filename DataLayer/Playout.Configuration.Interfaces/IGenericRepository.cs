using System;
using System.Linq;
using System.Linq.Expressions;
using Playout.Configuration.BaseModel.Interfaces;

namespace Playout.Configuration.Interfaces
{
    public interface IGenericRepository<T> : IDisposable where T : class, IBaseModel, new()
    {
	    void Add(T entity);
		void Update(T entity);
		void Remove(T entity);
	    T FindSingle(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includes);
		IQueryable<T> Find(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includes);
	    IQueryable<T> FindIncluding(params Expression<Func<T, object>>[] includeProperties);
	    IQueryable<T> GetAll();
		int Count(Expression<Func<T, bool>> predicate = null);	
		bool Exists(Expression<Func<T, bool>> predicate = null);
	}
}
