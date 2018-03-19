using Playout.Configuration.Contexts;
using Playout.Configuration.Interfaces;
using Playout.Configuration.Model;
using Playout.Configuration.Repositories;
using Playout.Configuration.UnitsOfWork.Base;

namespace Playout.Configuration.UnitsOfWork
{
	public class ConfigurationUnitOfWork : BaseUnitOfWork
	{
		public ConfigurationUnitOfWork(ConfigurationContext context) : base(context)
		{
		}

		private IGenericRepository<Workstation> _workstationRepository;
		public IGenericRepository<Workstation> WorkstationRepository => _workstationRepository ?? (_workstationRepository = new GenericRepository<Workstation>(Context));

	}
}
