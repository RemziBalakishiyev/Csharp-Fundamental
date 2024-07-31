using _14.Ders_Generics_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Ders_Generics_.Extensions
{
    internal static class PersonExtension
    {
        public static void ForeEachPerson(this IEnumerable<Person> people )
        {
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Id} - {person.FullName}");
            }
        }
    }
}
