using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Data.DTO
{
    public class productDetail
    {
        public productDetail(products p)
        {
            id = p.id;
            productName = p.productName;
            description = p.description;
            price = p.price;
            pictureId = p.pictureId;
            rate = p.rate;
            productTypeId = p.productTypeId;
            productTypeName = p.products_type.name;
            barId = p.barId;
            barName = p.bars.name;
        }
        public int quantity { get; set; }
        public int id { get; set; }
        public string productName { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string pictureId { get; set; }
        public double rate { get; set; }
        public int productTypeId { get; set; }
        public string productTypeName { get; set; }
        public int barId { get; set; }
        public string barName { get; set; }
    }
}