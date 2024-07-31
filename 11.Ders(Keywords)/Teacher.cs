using _11.Ders_Keywords_.Classes;
using _11.Ders_Keywords_.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _11.Ders_Keywords_.Enums.TeacherEnums;

namespace _11.Ders_Keywords_
{


    internal class Teacher:Person
    {


        //public Teacher()
        //{
        //    Console.WriteLine("Teacher constructor method is work!");
        //}

        ///// <summary>
        ///// Static Ctor metod parametr ala bilmez ve overload ola bilmez!
        ///// Normal ctor-dan daha once isleyir 
        ///// Static ctor sadece bir defe isleyir
        ///// </summary>
        
        //static Teacher()
        //{
        //    Console.WriteLine("Static constructor method is work!");
        //}
        public int Id { get; set; }

        public double Salary { get; set; }

        public DateTime DateOfBirth { get; set; }
      
        public Degree EducationDegree { get; set; }

        public Gender Gender { get; set; }

        public double CalcNetSalaryForTeacher()
        {
            return Calculation.CalcNetSalary(Salary);
        }

        public void DisplayInfo()
        {
           
            Console.WriteLine($"{FirstName} {LastName} salary is {CalcNetSalaryForTeacher()}, Teacher is {DateOfBirth.CalcAge()} ");
            Console.WriteLine($"{FirstName} {LastName} degree is {EducationDegree}");
        }
    }
}
