using System;
using Microsoft.EntityFrameworkCore;
using Playout.Configuration.Interfaces;

namespace Playout.Configuration.UnitsOfWork.Base
{
	public abstract class BaseUnitOfWork : IUnitOfWork
	{
		public DbContext Context { get; }

		protected BaseUnitOfWork(DbContext context)
		{
			Context = context;
		}

		public void Save()
		{
			Context.SaveChanges();
		}

		private bool _disposed;

		protected virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				if (disposing)
				{
					Context.Dispose();
				}
			}
			_disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
