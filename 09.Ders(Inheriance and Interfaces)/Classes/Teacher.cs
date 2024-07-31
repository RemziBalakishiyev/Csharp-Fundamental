using _09.Ders_Inheriance_and_Interfaces_.Interfaces;

namespace _09.Ders_Inheriance_and_Interfaces_.Classes
{
    internal class Teacher : Person, IPerson, IEmployee 
    {

        public Teacher():base("Teacher message")
        {
            
        }

        public int Experience { get; set; }

        private double salary;

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 250)
                {
                    throw new ArgumentException("Salary must be greater than 250");
                }
                salary = value;
            }
        }

        public void FeedBackMessage()
        {
            Console.WriteLine("I am Teacher and I love my students :)");
        }

        public double NetSalary() => Salary - (Salary * 0.04);
    }
}
