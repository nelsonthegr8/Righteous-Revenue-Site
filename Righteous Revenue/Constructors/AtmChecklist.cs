using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceSite.Constructors
{
    public class AtmChecklist
    {
        public string username { get; set; }
        public string billname { get; set; }
        public int billamount { get; set; } 
        public int twenty { get; set; }
        public int ten { get; set; }
        public int five { get; set; }
        public int one { get; set; }
        public int id { get; set; }

        public AtmChecklist()
        {

        }
        ///<summary>
        ///Constructor is used to add all the paramaters needed to save to the database
        ///</summary>
        public AtmChecklist(string username, string billname, int billamount)
        {
            this.username = username;
            this.billname = billname;
            this.billamount = billamount;
            billamntBreakdown(billamount);
        }

        private void billamntBreakdown(int billAmount) 
        {
            int remainder = 0;
            twenty = billAmount / 20;
            remainder = billAmount - (twenty * 20);
            ten = remainder / 10;
            remainder = remainder - (ten * 10);
            five = remainder / 5;
            remainder = remainder - (five * 5);
            one = remainder;
        }

    }
}