using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Ders_Inheriance_and_Interfaces_.Classes
{
    internal class Person
    {

        public Person(string message)
        {
            Console.WriteLine("Person class is work! Your message : {0}",message);
        }
        public string Id { get; private set; } = Guid.NewGuid().ToString();
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First Name can't be null");
                }
                firstName = value;
            }
        }
        private int salary;

        public int Salary
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

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last Name can't be null");
                }
                lastName = value;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Id - {Id} Full Name : {FirstName} {LastName}");
        }

        
    }
}
