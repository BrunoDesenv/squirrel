using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Infra.Web.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        // GET api/Usuario
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Usuario/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Usuario
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Usuario/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Usuario/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
