using Application.Data.DTO;
using Application.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Application.WebApi.Controllers
{
    [RoutePrefix("api/bars")]
    public class barsController : ApiController
    {
        IBarService service = new BarService();
        // GET: api/bars
        public IEnumerable<bar> Get()
        {
            return service.getBares();
        }

        // GET: api/bars/5
        public bar Get(int id)
        {
            return service.getBar(id);
        }

        [HttpGet]
        [Route("{id}/products")]
        public IEnumerable<product> get(int id)
        {
            return service.getProductsByBarId(id);
        }

        [HttpGet]
        [Route("{id}/products/snacks")]
        public IEnumerable<product> getSnacks(int id)
        {
            return service.getSnacksByBarId(id);
        }

        [HttpGet]
        [Route("{id}/products/drinks")]
        public IEnumerable<product> getDrinks(int id)
        {
            return service.getDrinksByBarId(id);
        }
        // POST: api/bars
        public void Post([FromBody]Data.bars value)
        {
            //service.saveBar(value);
        }
        // PUT: api/bars/5
        public void Put(int id, [FromBody]Data.bars value)
        {
        }

        // DELETE: api/bars/5
        public void Delete(int id)
        {
        }
    }
}
