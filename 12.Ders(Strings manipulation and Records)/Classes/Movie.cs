using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Ders_Strings_manipulation_and_Records_.Classes
{
    internal partial class Movie
    {
        public int Id { get; set; }
        public string Name { get; init; }
        public double ImdbPoint { get; set; }


        public Movie(string name,double imdbPoint)
        {
            Id = 0;
            Name = name;
            ImdbPoint = imdbPoint;
        }

        public void Deconstruct(out int id, out string name, out double imdpPoint)
        {
            id = Id;
            name = Name;
            imdpPoint = ImdbPoint;
        }

    }


    partial class Movie
    {
        public void DisplayInformation()
        {
            Console.WriteLine($"{Id}, {Name}, {ImdbPoint}");
        }
    }
}
