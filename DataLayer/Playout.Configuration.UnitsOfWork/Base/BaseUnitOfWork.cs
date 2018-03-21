using System;
using Playout.Configuration.Interfaces;

namespace Playout.Configuration.UnitsOfWork.Base
{
	public abstract class BaseUnitOfWork : IUnitOfWork
	{
		public IConfigurationContext Context { get; }

		protected BaseUnitOfWork(IConfigurationContext context)
		{
			Context = context;
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
