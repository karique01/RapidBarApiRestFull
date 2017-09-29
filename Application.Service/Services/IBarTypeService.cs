using Application.Data;
using Application.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services
{
    public interface IBarTypeService
    {
        List<barType> getBarTypes();
    }
}
