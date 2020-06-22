using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI.WebControls;

namespace FinanceSite.Constructors
{
    public class UserInformation
    {
        string username { get; set; }
        string password { get; set; }
        string firstname { get; set; }
        string lastname { get; set; }
        /// <summary>
        /// Holds the user information entered during the sign up stage
        /// </summary>
        public UserInformation() 
        {
           
        }
        /// <summary>
        /// Add user name, password, first name, and last name of user
        /// into the contructor for encapsolated use
        /// </summary>
        public UserInformation(string u,string p, string f, string l)
        {
            username = u;
            password = p;
            firstname = f;
            lastname = l;
        }   

        public string getUsername() 
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }
        public string getFirstname()
        {
            return firstname;
        }
        public string getLastname()
        {
            return lastname;
        }
    }
}