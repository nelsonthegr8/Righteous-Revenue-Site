using FinanceSite.Constructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinanceSite
{
    public partial class Login_Register_Page : System.Web.UI.Page
    {
        List<UserInformation> user = new List<UserInformation>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Loginbtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();          
            int status = db.userLogin(new UserLoginInfo(Usertxt.Text, Passtxt.Text));
            if (status == 1)
            {
                Response.Redirect("~/Home.aspx?id="+Usertxt.Text);
            }
            else 
            {
                lblMessage.Text = "Invalid Username or Password";
            }
        }
    }
}