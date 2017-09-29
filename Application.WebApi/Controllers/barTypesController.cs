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
    public class barTypesController : ApiController
    {
        IBarTypeService service = new BarTypeService();
        // GET: api/barTypes
        public List<barType> Get()
        {
            return service.getBarTypes();
        }

        // GET: api/barTypes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/barTypes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/barTypes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/barTypes/5
        public void Delete(int id)
        {
        }
    }
}
