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

            //busco en la tabla de customers por si es un customer
            customers c = context.customers.FirstOrDefault(x => x.userId == u.id);
            if (c != null) 
                return new User(u,CONSTANTES.USER_TYPE_CUSTOMER);
            //busco en la tabla de employees por si es un employee
            employees e = context.employees.FirstOrDefault(x => x.userId == u.id);
            if (e != null)
                return new User(u, CONSTANTES.USER_TYPE_EMPLOYEE);
            //busco en la tabla de managers por si es un manager
            managers m = context.managers.FirstOrDefault(x => x.userId == u.id);
            if (m != null)
                return new User(u, CONSTANTES.USER_TYPE_MANAGER);
            //null si no encontró su tipo de user en las demas tablas
            return null;
        }

        public void register(users user)
        {
            context.users.Add(user);
            customers cus = new customers() { email = user.userName, userId = user.id };
            context.customers.Add(cus);
            context.SaveChanges();
        }
    }
}