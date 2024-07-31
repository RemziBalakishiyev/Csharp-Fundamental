


using _09.Ders_Inheriance_and_Interfaces_.Classes;
using _09.Ders_Inheriance_and_Interfaces_.Interfaces;

//Student student = new Student
//{
//    FirstName = "Bruce",
//    LastName = "Wayne",
//    Grade = "A"
//};
//student.DisplayInfo();


//Teacher teacher = new Teacher
//{
//    FirstName = "John",
//    LastName = "Wick",
//    Salary = 3000
//};
//teacher.DisplayInfo();

//Person person = new Person
//{
//    FirstName = "Walter",
//    LastName = "White",
//};
//person.DisplayInfo();

/// Base class referans örnək olaraq öz inherit olduğu class-ları ala bilər
//Person personStd = new Student
//{
//    FirstName = "Bruce",
//    LastName = "Wayne"
//};

//personStd.DisplayInfo();

//Person personTch = new Teacher();


Student student = new Student("Message from program cs")
{
    FirstName = "Bruce",
    LastName = "Wayne",
    Grade = "A"
};
student.DisplayInfo();

Guardian guardian = new Guardian();
guardian.Salary = 4000;

Console.WriteLine(guardian.NetSalary());


// 1. Eyni metod imzasi amma ferqli body deyerlerine sahib olan metodlarin tekrari
// 2. Bir class-in yalniz bir class-dan inherit ola  bilmesi
// 3. Base class-in komekçi class olmasına baxmayara new olub istifadə oluna bilməsi

// Class-lar data-lardan (field ve prop) ve behaviour-lardan (Metod) ibaret idi


Employee employee = new Employee();

IPerson person = new Student();
person.FeedBackMessage();


