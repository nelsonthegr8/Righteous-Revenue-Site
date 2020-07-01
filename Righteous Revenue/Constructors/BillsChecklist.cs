using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceSite.Constructors
{
    public class BillsChecklist
    {
        
        public string username { get; set; }
        public string billname { get; set; }
        public double billamount { get; set; }
        public bool Check { get; set; }
        public int id { get; set; }

        public BillsChecklist()
        {

        }
        /// <summary>
        /// Use this to add bill checklist to database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="billname"></param>
        /// <param name="billamount"></param>
        /// <param name="Check"></param>
        public BillsChecklist( string username,string billname, double billamount)
        {
            this.username = username;
            this.billname = billname;
            this.billamount = billamount;
            this.Check = Check;
        }

    }
}