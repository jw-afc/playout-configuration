using System.Collections.Generic;
using System.Linq;
using Playout.Configuration.Model;
using Playout.Configuration.UnitsOfWork;

namespace Playout.Configuration.BusinessLogic
{
	public class Scenarios
	{
		public static List<Scenario> GetAll(ConfigurationUnitOfWork unitOfWork)
		{
			return unitOfWork.ScenariosRepository.GetAll();
		}

		public static Scenario GetById(string id, ConfigurationUnitOfWork unitOfWork)
		{
			return GetAll(unitOfWork).SingleOrDefault(p => p.Id == id);
		}
	}
}
