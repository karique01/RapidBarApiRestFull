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
    [RoutePrefix("api/order")]
    public class orderController : ApiController
    {
        OrderService service = new OrderService();

        // GET: api/order
        [HttpGet]
        [Route("{userId}")]
        public IEnumerable<orden> Get(int userId)
        {
            return service.getOrders(userId);
        }

        [HttpGet]
        [Route("{orderId}/details")]
        public IEnumerable<productDetail> GetProductDetails(int orderId)
        {
            return service.getProductDetailsByOrder(orderId);
        }

        public orders Post([FromBody]orders value)
        {
            return service.postOrder(value);
        }

        // PUT: api/order/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/order/5
        public void Delete(int id)
        {
        }
    }
}
