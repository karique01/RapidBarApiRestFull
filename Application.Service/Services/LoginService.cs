using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application.Data.DTO;
using Application.Data;

namespace Application.Service.Services
{
    public class LoginService : ILoginService
    {
        rapidbarEntities context = new rapidbarEntities();
        public User Login(UserLogin userLogin)
        {
            users u = context.users.FirstOrDefault(x => x.userName == userLogin.userName && x.password == userLogin.password);
            if (u == null) return null;
            return new User(u);
        }
    }
}