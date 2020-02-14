using Proyecto_AcessoADatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proyecto_AcessoADatos.Controllers
{
    public class CuentaController : ApiController
    {
        // GET: api/cuenta
       public IEnumerable<string> Get()
        {
            //Devuelve un array de eventos en formato JSON
            /*var repo = new cuentaRepository();
            List<cuenta> cuentas= repo.Retrieve();
            return cuentas;*/
            return new string[] { "value1", "value2" };
        }

        // GET: api/cuenta/5
        public string Get(int id)
        {
            /*var repo = new cuentaRepository();
            cuenta c = repo.Retrieve();*/
            return "value";
        }

        // POST: api/cuenta
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/cuenta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/cuenta/5
        public void Delete(int id)
        {
        }
    }
}
