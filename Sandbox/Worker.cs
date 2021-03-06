﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker : Employee

    {
        private int hourlyPay;
        private int hoursWorkedPerMonth;


        public Worker(string name, int hourlyPay, int hoursWorkedPerMonth) : base(name)
        {
            this.hourlyPay = hourlyPay;
            this.hoursWorkedPerMonth = hoursWorkedPerMonth;
        }

        public override int GetBonusPerMonth()
        {
            throw new NotImplementedException();
        }

        public override int GetSalaryPerMonth()
        {
            return hoursWorkedPerMonth * hourlyPay;
        }

        public override bool IsBonusPaidOut()
        {
            throw new NotImplementedException();
        }
    }
}
