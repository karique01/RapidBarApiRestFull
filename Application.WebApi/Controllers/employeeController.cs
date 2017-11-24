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
    [RoutePrefix("api/employee")]
    public class employeeController : ApiController
    {
        EmployeeService service = new EmployeeService();
        // GET: api/employee
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("{id}/order")]
        public IEnumerable<orden> get(int id)
        {
            return service.getOrdersByUserId(id);
        }

        [HttpGet]
        [Route("{id}/order/false")]
        public IEnumerable<orden> getOrdersFalse(int id)
        {
            return service.getOrdersByUserIdFalse(id);
        }

        // POST: api/employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/employee/5
        public void Delete(int id)
        {
            
        }
    }
}
