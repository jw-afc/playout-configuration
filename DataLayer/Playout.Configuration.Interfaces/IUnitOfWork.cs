using System;
using Microsoft.EntityFrameworkCore;

namespace Playout.Configuration.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
	    void Save();
	    DbContext Context { get; }
	}
}
