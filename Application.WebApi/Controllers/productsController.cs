using Application.Data.DTO;
using Application.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Application.WebApi.Controllers
{
    [RoutePrefix("api/products")]
    public class productsController : ApiController
    {
        ProductService service = new ProductService();
        // GET: api/products
        public IEnumerable<product> Get()
        {
            return service.getProducts();
        }

        // GET: api/products/5
        public product Get(int id)
        {
            return service.getProduct(id);
        }

        [HttpGet]
        [Route("{rate}")]
        public IEnumerable<product> getByRate(int rate)
        {
            return service.getProductsByRate(rate);
        }

        [HttpGet]
        [Route("snacks")]
        public IEnumerable<product> getSnacks()
        {
            return service.getSnacks();
        }

        [HttpGet]
        [Route("drinks")]
        public IEnumerable<product> getDrinks()
        {
            return service.getDrinks();
        }
        // POST: api/products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/products/5
        public void Delete(int id)
        {
        }
    }
}
