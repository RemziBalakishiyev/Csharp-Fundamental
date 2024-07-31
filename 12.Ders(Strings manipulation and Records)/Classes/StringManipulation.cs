using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Ders_Strings_manipulation_and_Records_.Classes
{
    internal partial class StringManipulation
    {
        public string TextOne { get; set; } = "I will be .Net developer";
        public string TextTwo { get; set; } = "C#,Javascript,Sql,Asp.net Core";

        public void Casing()
        {
            Console.WriteLine(TextOne.ToLower());
            Console.WriteLine(TextTwo.ToUpper());
        }

        public void Spliting()
        {
            string[] splitinStrings = TextTwo.Split(",");
            string[] splitinStrings2 = TextOne.Split(" ");
            foreach (string split in splitinStrings)
            {
                Console.WriteLine(split);
            }
        }


        public void ReversString(string str)
        {
            char[] symbolsOfStr = str.ToCharArray();
            string reverseStr = "";
            for (int i = symbolsOfStr.Length - 1; i >=0; i--)
            {
                Console.WriteLine(symbolsOfStr[i] + " -  "+i);
                reverseStr += symbolsOfStr[i];
            }
            Console.WriteLine(reverseStr);
        }


        public void JoinsStr()
        {
            string[] programmingTechnologies = ["C#", "React", "Html"];

            Console.WriteLine(string.Join("-",programmingTechnologies));
        }

        public void ContainsStr()
        {
            Console.WriteLine(TextOne.Contains("java"));
        }
    }


    partial class StringManipulation
    {
        public void AppendSb()
        {
            StringBuilder sb = new StringBuilder("Hello");

            sb.AppendLine(" ");
            sb.Append("World");
           
            Console.WriteLine(sb.ToString());

        }
    }
}
