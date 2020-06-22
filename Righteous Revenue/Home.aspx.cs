using FinanceSite.Constructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinanceSite
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<AtmChecklist> AtmCheck;
            if (!IsPostBack)
            {
                DataAccess db = new DataAccess();
                List<FirstandLast> name = db.getFirstandLast(Request.QueryString["id"]);
                AtmCheck = db.GetAtmChecklist(Request.QueryString["id"]);
                foreach (AtmChecklist item in AtmCheck)
                {
                    Atmchkbx.Items.Add(" - " + item.billname + ":  $" + item.billamount);
                }
                //UserHeader.InnerText = "Welcome, " + name[0].firstname + " " + name[0].lastname + "!";
            }
        }
    }
}