

Console.WriteLine();

//string firstName;
//string lastName;
//string email;

//string carName;
//string model;

//void Acceleration()
//{
//    Console.WriteLine("Acceleration is work");
//}
//void DisplayInfo()
//{
//    Console.WriteLine("Person info is loading...");
//}

//Person person = new Person();// referans orneyinin alinmasi

//person.firstName = "Bruce";
//person.lastName = "Wayne";
//person.email = "bwayne@boolean.com";

//Console.WriteLine(person.firstName);
//Console.WriteLine(person.lastName);

//person.DisplayInfo();


Car bmwf16 = new Car("BMW", "F16",100);
bmwf16.Acceleration();
bmwf16.Acceleration();
bmwf16.Acceleration();




Car mercedesBenz = new Car("Mercedes", "S-class",80);
mercedesBenz.Acceleration();
mercedesBenz.Acceleration();



Person bruce = new Person("Bruce","Wayne","bwayne@boolean.com");// referans orneyinin alinmasi
bruce.DisplayInfo();



Person jalal = new Person("Celal", "Qasimzade", "jalal@boolean.com");
Console.WriteLine(jalal.firstName);
jalal.DisplayInfo();


//person = new Person();

//person.firstName = "Walter";
//person.lastName = "White";
//Console.WriteLine(person.firstName);
//Console.WriteLine(person.lastName);

class Person
{
    public string firstName;
    public string lastName;
    public string email;

    public Person(string firstName,string lastName,string email)
    {
        this.firstName=firstName;
        this.lastName=lastName;
        this.email = email;
    }
    public void DisplayInfo()
    
    {
        Console.WriteLine($"Person full Name : {firstName} {lastName}");
        Console.WriteLine($"Person email : {email}");
    }
}


class Car(string carName,string model,int speed)
{
    public string carName=carName;
    public string model=model;
    public int speed=speed;
    public void Acceleration()
    {
        speed += 20;
        Console.WriteLine($"{model} {carName} is {speed}");
    }
}