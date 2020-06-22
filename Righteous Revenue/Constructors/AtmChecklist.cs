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
        public double billamount { get; set; }
        public int twenty { get; set; }
        public int ten { get; set; }
        public int five { get; set; }
        public int one { get; set; }
        public bool Check { get; set; }
        public int id { get; set; }

        public AtmChecklist()
        {

        }
        ///<summary>
        ///Constructor is used to add all the paramaters needed to save to the database
        ///</summary>
        public AtmChecklist(string username, string billname, double billamount, int twenty, int ten, int five, int one, bool Check)
        {
            this.username = username;
            this.billname = billname;
            this.billamount = billamount;
            this.twenty = twenty;
            this.ten = ten;
            this.five = five;
            this.one = one;
            this.Check = Check;
        }

    }
}