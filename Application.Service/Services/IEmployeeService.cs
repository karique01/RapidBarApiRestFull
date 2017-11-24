using Application.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services
{
    public interface IEmployeeService
    {
        List<orden> getOrdersByUserId(int userId);
        List<orden> getOrdersByUserIdTrue(int userId);
        List<orden> getOrdersByUserIdFalse(int userId);
    }
}
