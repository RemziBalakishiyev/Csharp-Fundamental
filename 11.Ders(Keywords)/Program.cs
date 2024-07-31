// See https://aka.ms/new-console-template for more information
using _11.Ders_Keywords_;
using _11.Ders_Keywords_.Classes;
using _11.Ders_Keywords_.Extensions;
using static _11.Ders_Keywords_.Enums.TeacherEnums;

//Console.WriteLine("Hello, World!");


//Employee employee = new Employee();
//employee.FirstName = "Bruce";
//employee.LastName = "Wayne";
//employee.Salary = 1000;


//Console.WriteLine(employee.CalcNetSalar());
//Console.WriteLine(Math.PI);
//Console.WriteLine(Math.E);


//Teacher teacher = new Teacher
//{
//    Salary = 2000,
//    FirstName = "Walter",
//    LastName = "White",
//    DateOfBirth = new DateTime(2000, 11, 15)
//};



//Console.WriteLine($"{teacher.GetFullName()} salary is {teacher.CalcNetSalaryForTeacher()}, Teacher is {teacher.DateOfBirth.CalcAge()}");


////Console.WriteLine(Calculation.CalcNetSalary(1200));

//Console.WriteLine(IntExtensions.IsEven(10));

//Console.WriteLine(10.IsEven());

//int number = 999;
//Console.WriteLine(number.IsEven());

//int number2 = 81;

//Console.WriteLine(16.SquardFromPower(4));


//Teacher teacher1 = new Teacher();
//Teacher teacher2 = new Teacher();
//Teacher teacher3 = new Teacher();


Teacher teacher1 = new Teacher
{
    Salary = 2000,
    FirstName = "Walter",
    LastName = "White",
    DateOfBirth = new DateTime(2000, 11, 15),
    EducationDegree = Degree.Dekan,
    Gender = Gender.Male,
};

teacher1.DisplayInfo();

Teacher teacher2 = new Teacher
{
    Salary = 3000,
    FirstName = "Marlyn",
    LastName = "Monroe",
    DateOfBirth = new DateTime(2000, 11, 15),
    EducationDegree = Degree.Tyutor,
    Gender = Gender.Female,
};
teacher2.DisplayInfo();

Console.WriteLine(Gender.Male.ToInt());











