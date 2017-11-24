using Application.Data;
using Application.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Application.WebApi.Controllers
{
    public class registerController : ApiController
    {
        LoginService service = new LoginService();
        // GET: api/register
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/register/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/register
        public string Post([FromBody]users value)
        {
            try
            {
                service.register(value);
                return "Ok";
            }
            catch (Exception)
            {
                return "Error";
            }            
        }

        // PUT: api/register/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/register/5
        public void Delete(int id)
        {
        }
    }
}
