using Proyecto_AcessoADatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proyecto_AcessoADatos.Controllers
{
    public class UsuarioController : ApiController
    {
        // GET: api/usuario
         public IEnumerable<string> Get()
         {
            return new string[] { "value1", "value2" };
         }

        // GET: api/usuario/5
        public string Get(int id)
        {
            /*var repo = new usuarioRepository();
            usuario u = repo.Retrieve();*/
            return "value";
        }

        // POST: api/usuario
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/usuario/5
        public void Delete(int id)
        {
        }
    }
}
