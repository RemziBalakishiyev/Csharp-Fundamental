using _08.Ders_Encapsulation_and_properties_.Classes;

Console.OutputEncoding = System.Text.Encoding.UTF8;

#region Encapsualtion
// Access modifiers
/// <summary>
/// 1 .  Private -> Sinifin icersinde elementlerin yalniz o sinif icerisinde cagrilmasas sebeb olur. Eger bir deyisenin ve metodun qarşısında heçnə yazılmayıbsa o dəyərləer private olaraq saxlanılır
/// 2. Public verilmis class ve fieldlerin istenilen yerde elcatanligina sebeb olur
/// </summary>

//Student student = new Student();

////student.Id = -100;
////student.age = 568;
////student.firstName = string.Empty;
////student.lastName = string.Empty;
////Console.WriteLine(student.password);

//student.FirstName = "Bruce";
//student.LastName = "Wayne";
//Console.WriteLine(student.Id);
//Console.WriteLine(student.FullName);


//student.DisplayInfo();
//class Student
//{

//    /// <summary>
//    /// Fields
//    /// </summary>

//    private string firstName;
//    private string lastName;
//    private int age;
//    private string password = Guid.NewGuid().ToString() + "-boolean";


//    public int Id { get; private set; }


//    public Student()
//    {
//        this.Id += 10;
//    }



//    public string FirstName
//    {

//        set
//        {
//            if (string.IsNullOrEmpty(value))
//            {
//                throw new ArgumentException("First Name dəyəri boş ola bilməz");
//            }
//            this.firstName = value;
//        }
//    }


//    public string FullName
//    {
//        get
//        {
//            return $"{firstName} {lastName}";
//        }
//    }


//    public string LastName
//    {

//        set
//        {
//            if (string.IsNullOrEmpty(value))
//            {
//                throw new ArgumentException("First Name dəyəri boş ola bilməz");
//            }
//            this.lastName = value;
//        }
//    }



//    public void DisplayInfo()
//    {

//        Console.WriteLine($"Id : {Id} Full Name : {firstName} {lastName} Age : {age}");
//    }
//} 
#endregion



Product product = new Product()
{
    ProductName = "Iphone 12",
    Price = 2000,
    OrderDate = 2024
}; // Object Initializer




Console.WriteLine($"Id : {product.Id} Product Name: {product.ProductName} Price : {product.SalesPrice} ");
