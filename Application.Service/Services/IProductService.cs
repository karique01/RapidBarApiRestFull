using Application.Data;
using Application.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services
{
    interface IProductService
    {
        List<product> getProducts();
        product getProduct(int id);
        List<product> getProductsByRate(int id);
        List<product> getSnacks();
        List<product> getDrinks();
        void saveProduct(products value);
    }
}
