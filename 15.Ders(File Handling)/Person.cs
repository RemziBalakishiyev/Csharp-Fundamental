using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Ders_File_Handling_
{
    internal class Person
    {
        public Guid Id { get; set; }=Guid.NewGuid();
        public string Name { get; set; }
    }
}
