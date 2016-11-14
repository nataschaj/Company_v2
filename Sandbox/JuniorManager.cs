using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class JuniorManager : Manager
    {
        private int hoursWorked;

        public JuniorManager(string name, int hoursWorked) : base(name)
        {
            this.hoursWorked = hoursWorked;
        }

        public override bool IsBonusPaidOut()
        {
            if (hoursWorked > 180)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }


    }
}
