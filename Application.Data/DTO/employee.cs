using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Data.DTO
{
    public class employee 
    {
        public int id { get; set; }
        public int roleId { get; set; }
        public int managerId { get; set; }
        public employee(employees e)
        {
            id = e.id;
            roleId = e.roleId;
            managerId = e.managerId;
        }
    }
}