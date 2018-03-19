using System;
using System.Linq;
using Playout.Configuration.Model;

namespace Playout.Configuration.Contexts
{
	public static class DbInitializer
	{
		public static void Initialize(ConfigurationContext context)
		{
			context.Database.EnsureCreated();
			
			if (context.Workstations.Any()) return; // DB has been seeded

			var workstations = new []
			{
				new Workstation("ATR", DateTime.Now),
				new Workstation("ATE", DateTime.Now.AddDays(-1), DateTime.Now.AddHours(-12)),
				new Workstation("CHL"),
				new Workstation("CHE", DateTime.Now),
				new Workstation("CFC", DateTime.Now.AddDays(-14), DateTime.Now.AddDays(-7), "Test")
			};

			foreach (var workstation in workstations) context.Workstations.Add(workstation);

			context.SaveChanges();
		}
	}
}
