using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application.Data;
using Application.Data.DTO;

namespace Application.Service.Services
{
    public class ProductService : IProductService
    {
        rapidbarEntities context = new rapidbarEntities();
        public List<product> getDrinks()
        {
            List<product> list = new List<product>();
            context.products.ToList().ForEach(x =>
            {
                if (x.products_type.id == CONSTANTES.PRODUCT_TYPE_BEBIDA)
                    list.Add(new product(x));
            });
            return list;
        }

        public product getProduct(int id)
        {
            return new product(context.products.FirstOrDefault(x => x.id == id));
        }

        public List<product> getProducts()
        {
            var list = new List<product>();
            context.products.ToList().ForEach(x => list.Add(new product(x)));
            return list;
        }

        public List<product> getProductsByRate(int rate)
        {
            List<product> list = new List<product>();
            context.products.ToList().ForEach(x =>
            {
                if (Convert.ToInt32(x.rate) == rate)
                    list.Add(new product(x));
            });
            return list;
        }

        public List<product> getSnacks()
        {
            List<product> list = new List<product>();
            context.products.ToList().ForEach(x =>
            {
                if (x.products_type.id == CONSTANTES.PRODUCT_TYPE_PIQUEO)
                    list.Add(new product(x));
            });
            return list;
        }

        public void saveProduct(products value)
        {
            context.products.Add(value);
            context.SaveChanges();
        }
    }
}