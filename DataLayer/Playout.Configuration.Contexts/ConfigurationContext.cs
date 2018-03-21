using System;
using Playout.Configuration.Interfaces;

namespace Playout.Configuration.Contexts
{
	public class ConfigurationContext : IConfigurationContext
	{
		public string Scenarios { get; set; }
		
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposing) return;
		}
	}
}
