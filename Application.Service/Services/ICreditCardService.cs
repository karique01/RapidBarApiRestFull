using Application.Data;
using Application.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services
{
    interface ICreditCardService
    {
        List<creditCard> getCreditCard();
        List<creditCard> getCreditCardByCustomer(int idCustomer);
        creditCard getCreditCard(int id);
        void saveCreditCard(credit_cards creditcard);
    }
}
