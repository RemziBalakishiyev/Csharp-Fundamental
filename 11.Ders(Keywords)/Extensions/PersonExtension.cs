using _11.Ders_Keywords_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Ders_Keywords_.Extensions
{
    internal static class PersonExtension
    {
        public static string GetFullName(this Person person)=>person.FirstName + " " + person.LastName;
    }
}
