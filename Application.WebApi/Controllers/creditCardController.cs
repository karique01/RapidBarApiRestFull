using Application.Data;
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
    public class creditCardController : ApiController
    {
        CreditCardService service = new CreditCardService();
        // GET: api/creditCard
        public IHttpActionResult Get()
        {
            return Ok("Acceso denegado");
        }

        // GET: api/creditCard/5
        public List<creditCard> Get(int id)
        {
            return service.getCreditCardByCustomer(id);
        }

        // POST: api/creditCard
        public void Post([FromBody]Data.credit_cards value)
        {
            service.saveCreditCard(value);
        }

        // PUT: api/creditCard/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/creditCard/5
        public void Delete(int id)
        {
        }
    }
}
