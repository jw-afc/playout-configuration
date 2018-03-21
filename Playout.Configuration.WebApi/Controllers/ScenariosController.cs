using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Playout.Configuration.BusinessLogic;
using Playout.Configuration.Contexts;
using Playout.Configuration.UnitsOfWork;

namespace Playout.Configuration.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ScenariosController : Controller
    {
	    private readonly ConfigurationUnitOfWork _unitOfWork;
		
	    public ScenariosController(IOptions<ConfigurationContext> options)
	    {
			_unitOfWork = new ConfigurationUnitOfWork(options.Value);
		}

	    [HttpGet]
		public IActionResult Get()
		{
			return Ok(Scenarios.GetAll(_unitOfWork));
        }

	    [HttpGet("{id}")]
		public IActionResult Get(string id)
	    {
		    var workstation = Scenarios.GetById(id, _unitOfWork);

			if (workstation == null) return NotFound();
			return Ok(workstation);
	    }
	}
}
