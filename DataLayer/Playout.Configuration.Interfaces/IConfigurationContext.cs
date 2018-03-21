using System;

namespace Playout.Configuration.Interfaces
{
    public interface IConfigurationContext : IDisposable
    {
	   string Scenarios { get; set; }
	}
}
