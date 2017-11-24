using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application.Data.DTO;
using Application.Data;

namespace Application.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        rapidbarEntities context = new rapidbarEntities();
        
        public List<orden> getOrdersByUserId(int userId)
        {
            return allOrders(userId).Where(x => x.state == true).ToList();
        }
        private List<orden> allOrders(int userId)
        {
            List<orden> orderss = new List<orden>();
            //encuentro al empleado
            employees employee = context.employees.FirstOrDefault(x => x.userId == userId);
            //encuentro su manager
            managers manager = context.managers.FirstOrDefault(x => x.id == employee.managerId);
            //encuentro el bar de donde es el empleado
            bars bar = context.bars.FirstOrDefault(x => x.id == manager.barId);
            //busco las ordenes por producto de ese bar
            var pbo = context.products_by_order.Where(x => x.products.barId == bar.id).ToList();
            //busco en las ordenes
            context.orders.ToList().ForEach(x =>
            {
                pbo.ForEach(y =>
                {
                    if (x.id == y.orderId)
                    {
                        if (!orderss.Exists(z => z.id == x.id))
                            orderss.Add(new orden(x));
                    }
                });
            });
            return orderss;
        }
        public List<orden> getOrdersByUserIdFalse(int userId)
        {
            return allOrders(userId).Where(x => x.state == false).ToList();
        }

        public List<orden> getOrdersByUserIdTrue(int userId)
        {
            return getOrdersByUserId(userId);
        }
    }
}