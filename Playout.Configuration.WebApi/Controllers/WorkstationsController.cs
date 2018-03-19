using Microsoft.AspNetCore.Mvc;
using Playout.Configuration.BusinessLogic;
using Playout.Configuration.Contexts;
using Playout.Configuration.Model;
using Playout.Configuration.UnitsOfWork;

namespace Playout.Configuration.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class WorkstationsController : Controller
    {
	    private readonly ConfigurationUnitOfWork _unitOfWork;

		public WorkstationsController(ConfigurationContext context)
		{
			_unitOfWork = new ConfigurationUnitOfWork(context);
		}

	    [HttpGet]
		public IActionResult Get()
		{
			return Ok(Workstations.GetAll(_unitOfWork));
        }

	    [HttpGet("{id}")]
		public IActionResult Get(int id)
	    {
		    var workstation = Workstations.GetById(id, _unitOfWork);

			if (workstation == null) return NotFound();
			return Ok(workstation);
	    }
		
	    [HttpPost]
	    public IActionResult Post([FromBody]Workstation workstation)
	    {
		    if (workstation == null) return BadRequest();
		    return Ok(Workstations.Create(workstation, _unitOfWork));
	    }
	}
}
