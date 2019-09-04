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
        private readonly DataService _data;

        public ValuesController(DataService _dataService)
        {
            _data = _dataService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<IncomingData>> Get()
        {
	    return _data.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<IncomingData> Get(int id)
        {
	    return _data.Get(id.ToString());
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] IncomingData value)
        {
	    var item = _data.Create(value);
	    return item.Id;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] IncomingData value)
        {
	    _data.Update(id.ToString(), value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
	    _data.Remove(id.ToString());
        }
    }
}
