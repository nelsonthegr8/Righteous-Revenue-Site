using FinanceSite.Constructors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinanceSite
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUpBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int status = db.usernameCheck(new UserLoginInfo(username.Text));

            if (status == 0)
            {
               int added = db.AddUser(new UserInformation(username.Text,password.Text,firstname.Text,lastname.Text));

                if (added == 1)
                {
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.Text = "User Has Been Added Successfully!";
                    resetFields();
                }
                else 
                {                              
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "There has been an error user has not been added! Try again later!";
                }

            }
            else 
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "User Name has Already Been Taken Please try a different one";
                username.Text = "";
                password.Text = "";
            }

        }

        private void resetFields() 
        {
            username.Text = "";
            password.Text = "";
            firstname.Text = "";
            lastname.Text = "";
        }
    }
}