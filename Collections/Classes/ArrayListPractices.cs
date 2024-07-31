using Collections.Extensions;
using System.Collections;

namespace Collections.Classes
{
    internal class ArrayListPractices
    {

        private ArrayList pls = new ArrayList();
        public void GivePractice()
        {

            string[] array = new string[3];
            array[0] = "x";
            ArrayList arrayList = new ArrayList();
           
            arrayList.Add("Bruce Wayne");
            arrayList.Add("Boolean Teach");
            arrayList.Add("Ramzi Balakishiyev");
            arrayList.Add(true);
            arrayList.Add(new { x = 12 });

            foreach (var arrList in arrayList)
            {
                Console.WriteLine(arrList);
            }



        }


        public void AddProgrammingLang(object programmingLanguage)
        {
            pls.Add(programmingLanguage);
        }



        public ArrayList GetPls()
        {
            return pls;
        }
    }
}
