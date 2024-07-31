using _14.Ders_Generics_.Classes;
using _14.Ders_Generics_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Ders_Generics_.Managers
{
    internal class EmployeeManager : GenericManager<Employee>
    {
        private static readonly List<Employee> _employees;
        static EmployeeManager()
        {
            _employees = new List<Employee>
            {
                new Employee{Id=1,FirstName="Bruce",LastName="Wayne",Salary=4400},
                new Employee{Id=2,FirstName="Walter",LastName="White",Salary=2400},
            };
        }

        public EmployeeManager(List<Employee> list) : base(list)
        {
        }

      

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employees.Remove(employee);
            Console.WriteLine($"{employee.FullName} deleted!");
        }

        public Employee GetEmployeeById(int Id)
        {
            foreach (var emp in _employees)
            {
                if (emp.Id == Id)
                {
                    return emp;
                }
            }
            return null;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employees;
        }
    }
}
