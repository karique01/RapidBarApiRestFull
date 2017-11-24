using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Data.DTO
{
    public class customer
    {
        public int id { get; set; }
        public string email { get; set; }
        public customer(customers c)
        {
            id = c.id;
            email = c.email;
        }
    }
}