using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Ders_Polymorphism_.Classes
{
    internal sealed class Americano:Coffee
    {

        private string chocolateVersion;
        public override string ChocolateVersion 
        { 
            get => chocolateVersion; 
            set => chocolateVersion="Dark Chocolate"; 
        }
    }
}
