using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Ders_Polymorphism_.Classes
{
    internal class Coffee:Product
    {
        public int Size { get; set; }
        public virtual string ChocolateVersion { get; set; }
        public sealed override void DisplayInfo()
        {
            Console.WriteLine("Kofeniz hazirdir!");
        }
    }
}
