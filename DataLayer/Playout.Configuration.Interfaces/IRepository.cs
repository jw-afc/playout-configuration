using System;
using System.Xml.Linq;

namespace Playout.Configuration.Interfaces
{
    public interface IRepository : IDisposable
    {
	    XDocument Document { get; }
	}
}
