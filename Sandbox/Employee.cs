using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    abstract class Employee
    {
        private String name; //instance field

        public Employee(String name) //constructor
        {
            this.name = name;
        }

        public String GetName() //metode
        {
            return name;
        }

        public abstract int GetSalaryPerMonth(); //abstrakte metoder

        public abstract int GetBonusPerMonth(); //abstrakte metoder

        public abstract bool IsBonusPaidOut(); //abstrakte metoder
    }
}
