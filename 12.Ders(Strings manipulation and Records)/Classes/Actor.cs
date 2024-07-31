using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Ders_Strings_manipulation_and_Records_.Classes
{
    internal record Actor
    {
        public int Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public Actor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Deconstruct(out string firstName,out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;

        }
    }

  
}
