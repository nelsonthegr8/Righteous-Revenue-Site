using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceSite.Constructors
{
    public class GoalsChecklist
    {
        public string username { get; set; }
        public string goal { get; set; }
        public int id { get; set; }
        public bool Check { get; set; }

        public GoalsChecklist()
        {
                
        }

        public GoalsChecklist(string username, string goal, int id, bool Check)
        {
            this.username = username;
            this.goal = goal;
            this.id = id;
            this.Check = Check;
        }

    }
}