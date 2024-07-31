

#region Method nədir yaradılması
// Metod kodun işləyən bloklarıdır
// DRY prinsipi -- Don't repeat yourself
//Console.WriteLine("Hello World");
//Console.WriteLine("My Name is Ramzi");
//Console.WriteLine("I am 25 year-old");

//Console.WriteLine("Hello World");
//Console.WriteLine("My Name is Ramzi");
//Console.WriteLine("I am 25 year-old");

//Console.WriteLine("Hello World");
//Console.WriteLine("My Name is Ramzi");
//Console.WriteLine("I am 25 year-old");

//Console.WriteLine("Hello World");
//Console.WriteLine("My Name is Ramzi");
//Console.WriteLine("I am 25 year-old");

//void Introduction()
//{
//    Console.WriteLine("Hello World");
//    Console.WriteLine("My Name is Ramzi");
//    Console.WriteLine("I am 23 year-old");
//}
//Introduction();
//Introduction();
//Introduction();
#endregion


#region Parametr


//int num1 = 10, num2 = 20, num3 = 30, num4 = 40;

//void Sum(int numberOne, int numberTwo)
//{
//    //Console.WriteLine($"numberOne {numberOne}, numberTwo {numberTwo}");
//    Console.WriteLine(numberOne+numberTwo);
//}

//Console.Clear();


//if (num1 + num2 > 50)
//{
//    Sum(num3,num4);
//}
//else
//{
//    //Console.WriteLine(num2 + num3);
//    Sum(num2, num3);
//}
#endregion
#region Geriyə dəyər qaytaran metodlar
// Üzərində Praqmatik əməliyyatlar aparılan metodlar geriyə dəəyər qaytaran metodlardı və ya metoddan aldığımız dəyəri normal dəyişən kimi istifadə edə biliriksə buda geriyə dəyərə qaytaran metoddur


//string GetName()
//{
//    return "Ramzi"; // string GetName = "Ramzi"
//}


//string name = GetName();
//void ChangeColor()
//{
//    Console.BackgroundColor = ConsoleColor.Green;
//}
//if (name == "Ramzi")
//{
//    Console.WriteLine($"my name is {GetName()}");
//}

//int Sum(int numberOne, int numberTwo)
//{
//    //Console.WriteLine($"numberOne {numberOne}, numberTwo {numberTwo}");
//    Console.WriteLine(numberOne + numberTwo);
//    return numberOne + numberTwo;
//}

//Sum(numberTwo:11,numberOne:50);

//if (Sum(num1, num2) > 50)
//{
//    Sum(num3, num4);
//}
//else
//{
//    //Console.WriteLine(num2 + num3);
//    Sum(num2, num3);
//}


#endregion


#region Params keyword






//int CalcArray(bool isSum, params int[] numbers)
//{
//    int sum = isSum ? 0 : 1;
//    foreach (var number in numbers)
//    {
//        if (isSum)
//        {
//            sum += number;
//        }
//        else
//        {
//            sum *= number;
//        }

//    }

//    return sum;
//}



//int[] numbers1 = [1, 5, 6];

//Console.WriteLine(CalcArray(false, numbers1));

//int[] numbers2 = [11, 21, 31, 41, 51, 61];
//Console.WriteLine(CalcArray(true, numbers2));


//int[] numbers3 = [1, 21, 3, 44, 50, 61];
//Console.WriteLine(CalcArray(true, numbers3));
//Console.WriteLine(CalcArray(false, 1, 2, 10));


#endregion

#region Method overloading

//using MyNamespace;

//MyClass myClass = new MyClass();
//myClass.Main();
//namespace MyNamespace
//{
//    class MyClass
//    {

//        public void Main()
//        {
//            //GetInformation1("Bruce","Wayne");
//            //GetInformation2("Bruce",20);
//            //GetInformation3("Bruce", "Wayne",50);

//            GetInformation("Bruce",30);
//        }

//        void GetInformation(string firstName, string lastName)
//        {
//            Console.WriteLine($"{firstName} {lastName}");
//        }

//        void GetInformation(string firstName, int age)
//        {
//            Console.WriteLine($"{firstName} {age}");
//        }



//        void GetInformation(string firstName, string lastName, int age)
//        {
//            Console.WriteLine($"{firstName} {lastName} {age}");
//        }

//    }
//}
#endregion

#region Lambda Expressions

//int Multp(int num1, int num2)
//{
//    return num1 * num2;
//}

int Multp(int num1, int num2) => num1 * num2;

#endregion