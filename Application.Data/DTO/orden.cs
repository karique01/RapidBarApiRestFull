using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Data.DTO
{
    public class orden
    {
        public orden(orders order)
        {
            totalAmount = order.totalAmount;
            date = order.date;
            barName = order.products_by_order.FirstOrDefault().products.bars.name;
            id = order.id;
            state = order.state;
        }
        public int id { get; set; }
        public double totalAmount { get; set; }
        public System.DateTime date { get; set; }
        public string barName { get; set; }
        public bool state { get; set; }
    }
}