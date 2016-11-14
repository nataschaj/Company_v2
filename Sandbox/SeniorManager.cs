using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class SeniorManager : Manager
    {
        private int performanceLevel;

        public SeniorManager(string name, int performanceLevel) : base(name)
        {
            this.performanceLevel = performanceLevel;
        }

        public override bool IsBonusPaidOut()
        {
            if (performanceLevel >= 6)
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
