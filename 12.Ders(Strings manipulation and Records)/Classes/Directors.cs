using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Ders_Strings_manipulation_and_Records_.Classes
{
    internal record Directors(string FirstName,string LastName)
    {
        public int AnyProp { get; set; }
    }
    
}
