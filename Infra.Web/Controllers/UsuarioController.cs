using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Model;
using Domain.Repositories.Read;
using Microsoft.AspNetCore.Mvc;

namespace Infra.Web.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUserRead _read;

        public UsuarioController(IUserRead read)
        {
            _read = read;
        }
        // GET api/Usuario
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var lista = _read.Teste();
            return lista;
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
