using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Ders_Keywords_.Extensions
{
    internal static class IntExtensions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(this int number) { return number % 2 == 1; }
        public static bool IsPositve(this int number) { return number > 0; }

        public static int SquardFromPower(this int number, int power)
        {
            return (int)Math.Pow(number, 1.0 / power);
        }

        public static int CalcAge(this DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;

            int age = today.Year - dateOfBirth.Year;
            DateTime addedYear = today.AddYears(-age);
            if (dateOfBirth.Date > addedYear)
            {
                age--;
            };

            return age;
        }
    }
}
