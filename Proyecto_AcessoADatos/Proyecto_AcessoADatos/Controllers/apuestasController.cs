using Proyecto_AcessoADatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proyecto_AcessoADatos.Controllers
{
    public class ApuestasController : ApiController
    {
        // GET: api/apuestas
        public IEnumerable<Apuestas> Get()
        {
            //Devuelve un array de eventos en formato JSON
            var repo = new ApuestasRepository();
            List<Apuestas> apuestas = repo.Retrieve();
            return apuestas;
        }


        [Authorize]
        public Apuestas Get(int id)
          {
              //Devuelve un array de eventos en formato JSON
              var repo = new ApuestasRepository();
              Apuestas apuestas = repo.Retrieve(id);
              return apuestas;
          }

            // GET: api/apuestas/5
            /* public List<apuestas> Get(int id)
             {
                 var repo = new apuestasRepository();
                 List<apuestas> a = repo.Retrieve();
                 return a;
             }*/

            // POST: api/apuestas
            public void Post([FromBody]Apuestas d)
        {
            var repo = new ApuestasRepository();
            //repo.Save(d);
        }

        // PUT: api/apuestas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/apuestas/5
        public void Delete(int id)
        {
        }
    }
}
