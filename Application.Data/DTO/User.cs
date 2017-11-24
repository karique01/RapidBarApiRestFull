﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Data.DTO
{
    public class User
    {
        public User(users user, int userType)
        {
            id = user.id;
            name = user.name;
            userName = user.userName;
            password = user.password;
            this.userType = userType;
        }
        public int id { get; set; }
        public string name { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int userType { get; set; }
    }
}