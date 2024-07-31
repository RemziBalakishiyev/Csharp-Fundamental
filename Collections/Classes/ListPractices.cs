using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classes
{
    internal partial class ListPractices
    {

        List<Product> products = new List<Product>();
        public void Practice()
        {
            List<int> numbers = new List<int>
            {
                12,
                13,
                14,
                15,
            };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }



        public void RemoveByIndex()
        {
            products.RemoveAt(1);

           
        }


        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void AddRangeList(IEnumerable<Product> enteredProducts)
        {
            products.AddRange(enteredProducts);
        }

        public List<Product> GetProducts() => products;
    }


    partial class ListPractices
    {


        public void EnumerablePractice()
        {

            //IEnumerable tipini adeten data axininda istifade edirik yeni əgər əlavə et yenilə sil kimi əməliyyatları etmirəksə sadəcə datanı alıb ekranda göstərmək (və ya front endə göndərmək və s.) hallarda istifadə
            IEnumerable<string> cities = new List<string>
            {
                "C#",
                "Javascript",
                "Sql"
            };

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

        }

        public void CollectionPractice()
        {
            ICollection<int> numbers = new List<int>
            {
                1,
                2,
               
            };

          
            numbers.Add(3);
          
            numbers.Add(4);

            numbers.Remove(3);


            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


        }
    }


}
