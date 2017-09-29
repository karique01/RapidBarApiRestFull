using Application.Data;
using Application.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services
{
    interface IOrderServcie
    {
        List<orden> getOrders(int idUser);
        List<orden> getOrdersByBar(int idBar);
        List<productDetail> getProductDetailsByOrder(int idBar);
        orders postOrder(orders order);
        void postProductByOrder(products_by_order value);
    }
}
