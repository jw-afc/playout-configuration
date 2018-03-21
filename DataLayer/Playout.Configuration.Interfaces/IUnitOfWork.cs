using System;

namespace Playout.Configuration.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
	    IConfigurationContext Context { get; }
	}
}
