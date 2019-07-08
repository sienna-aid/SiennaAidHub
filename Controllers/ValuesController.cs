using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SiennaAidHub.Models;
using SiennaAidHub.Services;

namespace SiennaAidHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
	private IncomingService _incomingService;

	public ValuesController(IncomingService incomingService)
	{
	    _incomingService = incomingService;
	}

	// GET api/values
	[HttpGet]
	public ActionResult<IEnumerable<string>> Get()
	{
	    return new string[] { "value1", "value2" };
	}

	// GET api/values/5
	[HttpGet("{id}")]
	public ActionResult<string> Get(int id)
	{
	    return "value";
	}

	// POST api/values
	[HttpPost]
	public ActionResult<string> Post([FromBody] Incoming value)
	{
	    Console.WriteLine("INCOMING: " + value.Value);

	    // TODO [CW]
	    // var created = _incomingService.Create(value);
	    // Console.WriteLine("CREATED: " + created.Id);

	    return ":-)";
	}

	// PUT api/values/5
	[HttpPut("{id}")]
	public void Put(int id, [FromBody] string value)
	{
	}

	// DELETE api/values/5
	[HttpDelete("{id}")]
	public void Delete(int id)
	{
	}
    }
}
