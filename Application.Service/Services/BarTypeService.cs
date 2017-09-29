using Application.Data;
using Application.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Service.Services
{
    public class BarTypeService : IBarTypeService
    {
        rapidbarEntities context = new rapidbarEntities();
        public List<barType> getBarTypes()
        {
            List<barType> list = new List<barType>();
            context.bar_types.ToList().ForEach(x => list.Add(new barType(x)));
            return list;
        }
    }
}