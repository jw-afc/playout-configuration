using System;
using System.IO;
using System.Xml.Linq;
using Playout.Configuration.Interfaces;

namespace Playout.Configuration.Repositories.Base
{
    public abstract class BaseRepository : IRepository
	{
		public XDocument Document { get; }

		protected BaseRepository(string filepath)
		{
			if (File.Exists(filepath)) Document = XDocument.Load(filepath);
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
	}
}
