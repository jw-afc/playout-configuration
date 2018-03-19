using System.Collections.Generic;
using System.Linq;
using Playout.Configuration.Model;
using Playout.Configuration.UnitsOfWork;

namespace Playout.Configuration.BusinessLogic
{
    public class Workstations
    {
	    public static List<Workstation> GetAll(ConfigurationUnitOfWork unitOfWork)
	    {
		    var workstations = unitOfWork.WorkstationRepository.GetAll();
		    return workstations.ToList();
		}

	    public static Workstation GetById(int id, ConfigurationUnitOfWork unitOfWork)
	    {
		    var workstation = unitOfWork.WorkstationRepository.FindSingle(p => p.Id == id);
		    return workstation;
	    }

	    public static Workstation Create(Workstation workstation, ConfigurationUnitOfWork unitOfWork)
	    {
		    if (workstation == null) return null;

		    unitOfWork.WorkstationRepository.Add(workstation);
			unitOfWork.Save();

		    return GetById(workstation.Id, unitOfWork);
	    }
    }
}
