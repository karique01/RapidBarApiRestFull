using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Data.DTO
{
    public class manager
    {
        public int id { get; set; }
        public string email { get; set; }
        public string barCreditCardNumber { get; set; }
        public DateTime creditCardExpirationDate { get; set; }
        public int roleId { get; set; }
        public int barId { get; set; }
        public manager(managers m)
        {
            id = m.id;
            email = m.email;
            barCreditCardNumber = m.barCreditCardNumber;
            creditCardExpirationDate = m.creditCardExpirationDate;
            roleId = m.roleId;
            barId = m.barId;
        }
    }
}