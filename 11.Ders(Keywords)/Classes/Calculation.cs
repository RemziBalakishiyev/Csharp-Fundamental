using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Ders_Keywords_.Classes
{
    internal class Calculation
    {
        public static double CalcNetSalary(double salary) => salary - (salary * Database.tax);
    }
}
