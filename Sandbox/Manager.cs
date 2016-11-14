using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Manager : Employee
    {
        private int monthlyBaseSalery;
        private int monthlyBonus;

        public Manager(string name) : base(name)
        {
            this.monthlyBaseSalery = 1500;
            this.monthlyBonus = 200;
        }

        public override int GetBonusPerMonth()
        {
            return monthlyBonus;
        }

        public override int GetSalaryPerMonth()
        {
            return monthlyBaseSalery;
        }

        public override bool IsBonusPaidOut()
        {
            throw new NotImplementedException();
        }
    }
}
