using System.Collections.Generic;
using System.Linq;
using Playout.Configuration.Model;
using Playout.Configuration.Repositories.Base;

namespace Playout.Configuration.Repositories
{
	public class ScenariosRepository : BaseRepository
	{
		public ScenariosRepository(string filepath) : base(filepath)
		{
		}

		public List<Scenario> GetAll()
		{
			var results = (from c in Document.Descendants("scenario")
				select new Scenario
				{
					Id = (string)c.Attribute("scenarioID"),
					DisplayId = (string)c.Attribute("displayID"),
					DalFile = (string)c.Attribute("dalFile")
				}).ToList();

			return results;
		}
	}
}
