using Playout.Configuration.Interfaces;
using Playout.Configuration.Repositories;
using Playout.Configuration.UnitsOfWork.Base;

namespace Playout.Configuration.UnitsOfWork
{
	public class ConfigurationUnitOfWork : BaseUnitOfWork
	{
		public ConfigurationUnitOfWork(IConfigurationContext context) : base(context)
		{
		}

		private ScenariosRepository _scenariosRepository;
		public ScenariosRepository ScenariosRepository => _scenariosRepository ?? (_scenariosRepository = new ScenariosRepository(Context.Scenarios));
	}
}
