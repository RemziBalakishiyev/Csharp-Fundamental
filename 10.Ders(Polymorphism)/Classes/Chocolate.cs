using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Ders_Polymorphism_.Classes
{
    internal class Chocolate:Product
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Chocolate information");
        }

        void ProductData()
        {
            Console.WriteLine("Product");
        }

        void ProductData(string data)
        {
            Console.WriteLine(data);
        }
    }
}
