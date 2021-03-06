﻿using Application.Data;
using Application.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Application.WebApi.Controllers
{
    public class productsByOrderController : ApiController
    {
        OrderService service = new OrderService();
        // GET: api/productsByOrder
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/productsByOrder/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/productsByOrder
        public void Post([FromBody]products_by_order value)
        {
            service.postProductByOrder(value);
        }

        // PUT: api/productsByOrder/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/productsByOrder/5
        public void Delete(int id)
        {
        }
    }
}
