using Proyecto_AcessoADatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proyecto_AcessoADatos.Controllers
{
    public class MercadoController : ApiController
    {

        // GET: api/mercado
        public IEnumerable<Mercado> Get()
        {
            //Devuelve un array de eventos en formato JSON
            var repo = new MercadoRepository();
            List<Mercado> mercados = repo.Retrieve();
            return mercados;

        }

        // GET: api/mercado/5
        //[Authorize(Roles = "Admin")]
        public Mercado Get(int id)
        {
            var repo = new MercadoRepository();
            Mercado d = repo.Retrieve(id);
            return d;
        }

        // POST: api/mercado
        public void Post([FromBody]Mercado merc)
        {
            var repo = new MercadoRepository();
            //repo.Savemercado(merc);

        }

        // PUT: api/mercado/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/mercado/5
        public void Delete(int id)
        {
        }
    }
}
