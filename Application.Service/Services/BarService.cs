using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application.Data;
using Application.Data.DTO;

namespace Application.Service.Services
{
    public class BarService : IBarService
    {
        rapidbarEntities context = new rapidbarEntities();
        public List<bar> getBares()
        {
            var list = new List<bar>();
            context.bars.ToList().ForEach(x => list.Add(new bar(x)));
            return list;
        }
        public bar getBar(int id)
        {
            return new bar(context.bars.FirstOrDefault(x => x.id == id));
        }
        public void saveBar(bars b)
        {
            context.bars.Add(b);
            context.SaveChanges();
        }

        public List<product> getProductsByBarId(int id)
        {
            List<product> list = new List<product>();
            bars b = context.bars.FirstOrDefault(x => x.id == id);
            b.products.ToList().ForEach(x => list.Add(new product(x)));
            return list;
        }

        public List<product> getSnacksByBarId(int id)
        {
            List<product> list = new List<product>();
            bars b = context.bars.FirstOrDefault(x => x.id == id);
            b.products.ToList().ForEach(x => 
            {
                if (x.products_type.id == CONSTANTES.PRODUCT_TYPE_PIQUEO)
                    list.Add(new product(x));
            });
            return list;
        }

        public List<product> getDrinksByBarId(int id)
        {
            List<product> list = new List<product>();
            bars b = context.bars.FirstOrDefault(x => x.id == id);
            b.products.ToList().ForEach(x =>
            {
                if (x.products_type.id == CONSTANTES.PRODUCT_TYPE_BEBIDA)
                    list.Add(new product(x));
            });
            return list;
        }
    }
}