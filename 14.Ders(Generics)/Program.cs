// See https://aka.ms/new-console-template for more information
using _14.Ders_Generics_.Classes;
using _14.Ders_Generics_.Extensions;
using _14.Ders_Generics_.Managers;



//EmployeeManager manager = new EmployeeManager();



//manager.Add(new Employee { Id = 3, FirstName = "John", LastName = "Wick", Salary = 5000 });
//manager.Add(new Employee { Id = 4, FirstName = "Jamie", LastName = "Lannister", Salary = 3000 });
//manager.Add(new Employee { Id = 5, FirstName = "Joshua", LastName = "Antony", Salary = 2000 });


//Console.Write("Write id which you want deleted : ");
//int deletedId = Convert.ToInt32(Console.ReadLine());

//var deletedEmployee = manager.GetEmployeeById(deletedId);
//manager.Delete(deletedEmployee);
//manager.GetEmployees().ForeEachPerson();



//Console.WriteLine("Hello, World!");

//MyExample<int> myExample1 = new MyExample<int>();
//myExample1.Get();
//myExample1.Add(1);

//Console.WriteLine("-------------");

//MyExample<string> myExample2 = new MyExample<string>();
//myExample2.Get();
//myExample2.Add("asdas");

//Console.WriteLine("-------------");

//MyExample<Employee> myExample3 = new MyExample<Employee>();
//myExample3.Get();
//myExample3.Add(new Employee());
//class MyExample<T>
//{
//    public void Get()
//    {
//        Console.WriteLine(typeof(T).Name);
//    }

//    public void Add(T data)
//    {
//        Console.WriteLine(data);
//    }
//}



TeacherManager teacherManager = new TeacherManager();

var teacher = teacherManager.GetDataById(1);
Console.WriteLine("-------------");