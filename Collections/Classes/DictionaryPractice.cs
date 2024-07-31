using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classes
{
    internal class DictionaryPractice
    {
        Dictionary<int, ProgrammingLang> pls = new Dictionary<int, ProgrammingLang>();
        public void Practice()
        {
            Dictionary<string, string> dictionaries = new Dictionary<string, string>();

            dictionaries.Add("pen", "Qelem");
            dictionaries.Add("cup", "Fincan");
            dictionaries.Add("flag", "Bayraq");

            foreach (KeyValuePair<string, string> item in dictionaries)
            {
                Console.WriteLine($"Key : {item.Key} Value : {item.Value}");
            }
        }



        public void AddNewPl(int key, ProgrammingLang lang)
        {
            pls.Add(key, lang);
        }

        public ProgrammingLang GetPlByKey(int key)
        {
            return pls[key];
        }
    }
}
