using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Data.DTO
{
    public class creditCard
    {
        public creditCard(credit_cards credit_card)
        {
            id = credit_card.id;
            number = credit_card.number;
            expirationDate = credit_card.expirationDate;
            idCustomer = credit_card.idCustomer;
        }
        public int id { get; set; }
        public string number { get; set; }
        public System.DateTime expirationDate { get; set; }
        public int idCustomer { get; set; }
    }
}