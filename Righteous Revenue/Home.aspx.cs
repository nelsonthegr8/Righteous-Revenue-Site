using FinanceSite.Constructors;
using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FinanceSite
{
    public partial class Home : System.Web.UI.Page
    {
        private List<AtmChecklist> AtmCheck = new List<AtmChecklist>();
        private String userName;
        private DataAccess db = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            userName = Request.QueryString["id"];           
            if (!IsPostBack)
            {                
                List<FirstandLast> name = db.getFirstandLast(userName);
                ResetAtmChecklist();
                UserHeader.InnerText = "Welcome, " + name[0].firstname + " " + name[0].lastname + "!";
            }
        }
        protected void atmchkchanged(object sender, EventArgs e)
        {
            updateCaculations();
        }

        protected void AtmAdd_Click(object sender, EventArgs e)
        {
            int billamnt = 0;
            if (AtmbillnameTxtbx.Text != null && AtmbillamntTxtbx.Text != null) 
            {
                try
                {
                    billamnt = Convert.ToInt32(AtmbillamntTxtbx.Text);
                }
                catch (FormatException) 
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please enter a valid bill amount." + "');", true);
                }

                db.AddAtmBill(new AtmChecklist(userName, AtmbillnameTxtbx.Text, billamnt));
                refillAtmCheck();
                Atmchkbx.Items.Add(" - " + AtmCheck[AtmCheck.Count - 1].billname + ":  $" + AtmCheck[AtmCheck.Count - 1].billamount);
                Atmchkbx.Items[Atmchkbx.Items.Count - 1].Value = AtmCheck[AtmCheck.Count - 1].id.ToString();
                AtmbillnameTxtbx.Text = "";
                AtmbillamntTxtbx.Text = "";
            }
        }

        private void resetChkbx(CheckBoxList chkbx) 
        {
            for (int i = 0; i < chkbx.Items.Count; i++) 
            {
                chkbx.Items[i].Selected = false;
            }
            //reset Atm numbers
            resetAtmNumbers();
        }

        protected void AtmUncheckAllbtn_Click(object sender, EventArgs e)
        {
            resetChkbx(Atmchkbx);
        }

        protected void AtmDeletebtn_Click(object sender, EventArgs e)
        {
            refillAtmCheck();
            List<int> indexes = new List<int>();
            foreach(ListItem Item in Atmchkbx.Items) 
            {
                if (Item.Selected) 
                {
                    db.RemoveItemFromCheckedList(Convert.ToInt32(Item.Value), 2);
                    indexes.Add(Atmchkbx.Items.IndexOf(Atmchkbx.Items.FindByValue(Item.Value)));
                }
            }

            for(int i = 0; i < indexes.Count; i++) 
            {
                Atmchkbx.Items.RemoveAt(indexes[i] - i);
            }

            updateCaculations();
        }

        private void ResetAtmChecklist() 
        {
            Atmchkbx.Items.Clear();
            refillAtmCheck();


            for (int i = 0; i < AtmCheck.Count; i++)
            {
                Atmchkbx.Items.Add(" - " + AtmCheck[i].billname + ":  $" + AtmCheck[i].billamount);
                Atmchkbx.Items[Atmchkbx.Items.Count - 1].Value = AtmCheck[i].id.ToString();
            }
        }

        private void updateCaculations() 
        {
            resetAtmNumbers();
            refillAtmCheck();
            for (int i = 0; i < Atmchkbx.Items.Count; i++) 
            {
                if (Atmchkbx.Items[i].Selected) 
                {
                    TwentyOutput.Text = (Convert.ToInt32(TwentyOutput.Text) + AtmCheck[i].twenty).ToString();
                    TenOutput.Text = (Convert.ToInt32(TenOutput.Text) + AtmCheck[i].ten).ToString();
                    FiveOutput.Text = (Convert.ToInt32(FiveOutput.Text) + AtmCheck[i].five).ToString();
                    SingleOutput.Text = (Convert.ToInt32(SingleOutput.Text) + AtmCheck[i].one).ToString();
                }
            }
        }

        private void resetAtmNumbers() 
        {
            TwentyOutput.Text = "0";
            TenOutput.Text = "0";
            FiveOutput.Text = "0";
            SingleOutput.Text = "0";
        }

        private void refillAtmCheck() 
        {
            AtmCheck.Clear();
            AtmCheck = db.GetAtmChecklist(userName);
        }

        
    }
}