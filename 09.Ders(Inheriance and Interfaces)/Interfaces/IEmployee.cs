using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Ders_Inheriance_and_Interfaces_.Interfaces
{
    internal interface IEmployee
    {
        double Salary { get; set; }
        public double NetSalary();
    }
}
