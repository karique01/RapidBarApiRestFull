using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application.Data.DTO;
using Application.Data;

namespace Application.Service.Services
{
    public class OrderService : IOrderServcie
    {
        rapidbarEntities context = new rapidbarEntities();
        public List<orden> getOrders(int idUser)
        {
            List<orden> list = new List<orden>();
            context.orders.ToList().ForEach(x => 
            {
                if (x.userId == idUser)
                    list.Add(new orden(x));
            });
            return list;
        }

        public List<orden> getOrdersByBar(int idBar)
        {
            List<orden> list = new List<orden>();
            context.orders.ToList().ForEach(x =>
            {
                if (x.products_by_order.FirstOrDefault().products.barId == idBar)
                    list.Add(new orden(x));
            });
            return list;
        }

        public List<productDetail> getProductDetailsByOrder(int orderId)
        {
            List<productDetail> list = new List<productDetail>();
            context.products_by_order.ToList().ForEach(x =>
            {
                if (x.orderId == orderId)
                {
                    productDetail p = new productDetail(x.products);
                    p.quantity = x.quantity;
                    list.Add(p);
                }
            });
            return list;
        }

        public orders postOrder(orders order)
        {
            context.orders.Add(order);
            context.SaveChanges();
            return order;
        }

        public void postProductByOrder(products_by_order value)
        {
            context.products_by_order.Add(value);
            context.SaveChanges();
        }
    }
}