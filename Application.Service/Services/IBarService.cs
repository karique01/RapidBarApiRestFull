using Application.Data;
using Application.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services
{
    public interface IBarService
    {
        List<bar> getBares();
        bar getBar(int id);
        List<product> getProductsByBarId(int id);
        List<product> getSnacksByBarId(int id);
        List<product> getDrinksByBarId(int id);
        void saveBar(bars bar);
    }
}
