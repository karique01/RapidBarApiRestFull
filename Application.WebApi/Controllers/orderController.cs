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
        [HttpGet]
        [Route("{orderId}/details/drinks")]
        public IEnumerable<productDetail> GetProductDetailsDrinks(int orderId)
        {
            return service.getProductDetailsByOrderDrinks(orderId);
        }
        [HttpGet]
        [Route("{orderId}/details/snacks")]
        public IEnumerable<productDetail> GetProductDetailsSnacks(int orderId)
        {
            return service.getProductDetailsByOrderSnacks(orderId);
        }
        public orders Post([FromBody]orders value)
        {
            return service.postOrder(value);
        }

        // PUT: api/order/5
        [HttpPut]
        [Route("{id}")]
        public void Put(int id)
        {
            service.deshacerEliminar(id);
        }

        // DELETE: api/order/5
        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            service.eliminar(id);
        }
    }
}
