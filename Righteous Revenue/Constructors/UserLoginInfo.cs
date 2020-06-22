using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace FinanceSite.Constructors
{
    public class UserLoginInfo
    {
        public string userName { get; set; }
        public string password { get; set; }

        public UserLoginInfo(string u, string p)
        {
            userName = u;
            password = p;
        }

        public UserLoginInfo(string u) 
        {
            userName = u;
        }

    }
}