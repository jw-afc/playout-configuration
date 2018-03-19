using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Playout.Configuration.BaseModel.Interfaces;
using Playout.Configuration.Interfaces;

namespace Playout.Configuration.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class, IBaseModel, new()
	{
		private readonly DbContext _context;

		public GenericRepository(DbContext context)
		{
			_context = context;
		}
		
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposing) return;
		}

		public void Add(T entity)
		{
			_context.Set<T>().Add(entity);
		}

		public void Update(T entity)
		{
			_context.Update(entity);
		}

		public void AddOrUpdate(T entity)
		{
			if (entity.Id == 0) Add(entity);
			else Update(entity);
		}

		public void Remove(T entity)
		{
			_context.Remove(entity);
		}
		
		
		public T FindSingle(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includes)
		{
			var set = FindIncluding(includes);
			return predicate == null ? set.FirstOrDefault() : set.FirstOrDefault(predicate);
		}
		
		public IQueryable<T> Find(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includes)
		{
			var set = FindIncluding(includes);
			return predicate == null ? set : set.Where(predicate);
		}

		public IQueryable<T> GetAll()
		{
			var set = _context.Set<T>();

			return set.AsQueryable();
		}

		public IQueryable<T> FindIncluding(params Expression<Func<T, object>>[] includeProperties)
		{
			IQueryable<T> set = _context.Set<T>();

			if (includeProperties != null)
			{
				foreach (var include in includeProperties) 
					set = set.Include(include);
			}

			return set.AsQueryable();
		}

		public int Count(Expression<Func<T, bool>> predicate = null)
		{
			var set = _context.Set<T>();
			return predicate == null ? set.Count() : set.Count(predicate);
		}

		public bool Exists(Expression<Func<T, bool>> predicate = null)
		{
			var set = _context.Set<T>();
			return predicate == null ? set.Any() : set.Any(predicate);
		}
	}
}
