using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application.Data.DTO;
using Application.Data;

namespace Application.Service.Services
{
    public class CreditCardService : ICreditCardService
    {
        rapidbarEntities context = new rapidbarEntities();

        public List<creditCard> getCreditCard()
        {
            List<creditCard> list = new List<creditCard>();
            context.credit_cards.ToList().ForEach(x => list.Add(new creditCard(x)));
            return list;
        }
        public List<creditCard> getCreditCardByCustomer(int idCustomer)
        {
            List<creditCard> list = new List<creditCard>();
            context.credit_cards.ToList().ForEach(x => 
            {
                if (x.idCustomer == idCustomer)
                    list.Add(new creditCard(x));
            });
            return list;
        }
        public creditCard getCreditCard(int id)
        {
            return new creditCard(context.credit_cards.FirstOrDefault(x => x.id == id));
        }

        public void saveCreditCard(credit_cards creditcard)
        {
            //busco el customer
            customers c = context.customers.FirstOrDefault(x => x.userId == creditcard.idCustomer);
            if (c == null) return;

            creditcard.idCustomer = c.id;
            context.credit_cards.Add(creditcard);
            context.SaveChanges();
        }
    }
}