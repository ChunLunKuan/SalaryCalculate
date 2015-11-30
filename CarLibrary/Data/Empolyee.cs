using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary.Data
{
    public class Empolyee
    {
        private int BaseSalary;
        private int Benefit;
        private int Salary;

        public int SetBaseSalary
        {
            get { return BaseSalary; }
            set
            {
                if (value <= 22000)
                    BaseSalary = 22000;
                else if (value >= 33000)
                    BaseSalary = 30000;
                else
                    BaseSalary = value;
            }
        }

        public int SetBenefit
        {
            get { return Benefit; }
            set
            {
                if (value <= 1000)
                    Benefit = 1000;
                else if (value >= 10000)
                    Benefit = 10000;
                else
                    Benefit = value;
            }
        }

        public int SetSalary
        {
            get { return Salary = BaseSalary + Benefit; }
            set { }
        }
    }
}