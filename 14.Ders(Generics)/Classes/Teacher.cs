using _14.Ders_Generics_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Ders_Generics_.Classes
{
    internal class Teacher:Person, ITable
    {
        public string Subject { get; set; }
    }
}
