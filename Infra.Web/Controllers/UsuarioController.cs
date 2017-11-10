using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Domain.Model;
using Domain.Repositories.Read;
using Domain.Repositories.Write;
using Microsoft.AspNetCore.Mvc;

namespace Infra.Web.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUserRead _read;
        private readonly IUserWrite _write;
        private const string COLLECTION_NAME = "User";

        public UsuarioController(IUserRead read,
        IUserWrite write)
        {
            _read = read;
            _write = write;
        }

        /// <summary>
        /// List all Users.
        /// </summary>
        // GET api/Usuario
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var lista = _read.GetAll();
            return lista;
        }

        /// <summary>
        /// Lista User by id
        /// </summary>
        /// <param name="id">id type GUID (required).</param>
        // GET api/Usuario/5
        [HttpGet("{id}")]
        public User Get(Guid id)
        {
            return _read.GetById(id);
        }


        /// <summary>
        /// Creates a User.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /User
        ///     {
        ///     }
        ///
        /// </remarks>
        /// <param name="user"></param>
        /// <returns>A newly-created User</returns>
        /// <response code="201">Returns the newly-created User</response>
        /// <response code="400">If the User is null</response>           
        [HttpPost]
        public IActionResult Post([FromBody]User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            user.Id = Guid.NewGuid();

            _write.Add(user);
            return Accepted();
        }

        // PUT api/Usuario/5
        [HttpPut("{user}")]
        public void Put([FromBody]User user)
        {
            _write.Update(user);
        }

        /// <summary>
        /// Deletes a specific User.
        /// </summary>
        /// <param name="id"> Id Type GUID</param>    
        // DELETE api/Usuario/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _write.Delete(id);
        }
    }
}
