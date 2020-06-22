using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dapper;
using Microsoft.Data.SqlClient;

namespace FinanceSite.Constructors
{
    public class DataAccess
    {
        public int userLogin(UserLoginInfo info) 
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FinanceDB"].ConnectionString;
            int status;
            using (SqlConnection con = new SqlConnection(connectionString)) 
            {
                SqlCommand cmd = new SqlCommand("financeLogin",con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username",info.userName);
                cmd.Parameters.AddWithValue("@Password",info.password);
                con.Open();
        
                status = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();
            }

            return status;
        }

        public int usernameCheck(UserLoginInfo info)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FinanceDB"].ConnectionString;
            int status;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Usernamecheck", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username", info.userName);
                
                con.Open();

                status = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();
            }

            return status;
        }

        public int AddUser(UserInformation info)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FinanceDB"].ConnectionString;
            int status;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username", info.getUsername());
                cmd.Parameters.AddWithValue("@Password", info.getPassword());
                cmd.Parameters.AddWithValue("@Firstname", info.getFirstname());
                cmd.Parameters.AddWithValue("@Lastname", info.getLastname());
                con.Open();

                status = Convert.ToInt32(cmd.ExecuteNonQuery());

                con.Close();
            }

            return status;
        }
        /// <summary>
        /// Send over type
        /// </summary>
        /// <param name="username"></param>
        /// <returns>List of all the bills they have in the Atm Withdrawl Calculator</returns>
        public List<AtmChecklist> GetAtmChecklist(string username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseConnection.CnnVal("FinanceDB")))
            {
                var output = connection.Query<AtmChecklist>($"SELECT billname, billamount,twenty,ten,five,one,checked,id FROM AtmChecklist WHERE username='{username}'").ToList();
                return output;
            }
        }

        public List<FirstandLast> getFirstandLast(string username) 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseConnection.CnnVal("FinanceDB")))
            {
                var output = connection.Query<FirstandLast>($"SELECT firstname, lastname FROM UserInformation WHERE username='{username}'").ToList();
                return output;
            }
        }
    }
}