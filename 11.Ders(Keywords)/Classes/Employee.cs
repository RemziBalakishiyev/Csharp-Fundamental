using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Ders_Keywords_.Classes
{
    internal class Employee:Person
    {

        public Employee()
        {
            Database database = new Database("asdasdasdasd-asdasd");
            Console.WriteLine(database.connectionKeyword+" connected to database successfuly!");
        }
        public int Id { get; set; }
      
        public double Salary { get; set; }

        public double CalcNetSalar()
        {
            return Salary - Salary * Database.tax; 
        }



    }
}
