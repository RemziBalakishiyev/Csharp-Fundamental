using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Ders_Inheriance_and_Interfaces_.Classes
{
    internal class Employee 
    {
        

        private double salary;

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 250)
                {
                    throw new ArgumentException("Salary must be greater than 250");
                }
                salary = value;
            }
        }

        public double NetSalary() => Salary - (Salary * 0.04);
    }
}
