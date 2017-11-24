using Application.Data;
using Application.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services
{
    interface ILoginService
    {
        User Login(UserLogin userLogin);
        void register(users user);
    }
}
