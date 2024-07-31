using static System.Console;
using static System.Convert;

OutputEncoding = System.Text.Encoding.UTF8;
#region If 
//int number3 = 17;
//{
//    Console.WriteLine(number3);
//    int number1 = 13;

//    {
//        int number2 = 15;
//        Console.WriteLine(number2);
//        Console.WriteLine(number1);
//        Console.WriteLine(number3);

//    }

//}

//if (true)
//{
//   Console.WriteLine("Emeliyyat isledi");
//}

//Console.WriteLine("Emeliyyat tamamlandi");


//Write("Type any number: ");
//int number = ToInt32(ReadLine());

//// Eger ededim musbetdir ekran rengini yasil et
//if (number >= 0)
//{
//  BackgroundColor = ConsoleColor.Green;
//}
//WriteLine("Operation  completed!");


//Write("Type your username : ");
//string userName = ReadLine();
//string sysUserName = "boolean";

//string role="user";
//Write("Secret Number : ");
//int secretNumber = ToInt32(ReadLine());


//if (secretNumber ==1)
//{
//    role = "Admin";
//}



//if(userName == sysUserName && role=="Admin")
//{
//    WriteLine($"Congrutlations {userName}");
//}




#endregion

#region Else Statements
// Eger ededim musbetdirse  ekran rengini yasil et menfidirse qirmizi


//short number = ToInt16(ReadLine());

//if (number > 0)
//{
//    BackgroundColor = ConsoleColor.Green;
//}
//else // Else statementi verilen "Şərtlər" doğru olmazsa ən sonda else ifadəsi çalışır
//{
//    BackgroundColor = ConsoleColor.Red;
//}
BackgroundColor = ConsoleColor.Black;
ForegroundColor = ConsoleColor.White;
//bool hasLicense;

//int dateOfBirthYear = ToInt16(ReadLine());

//int age = 2024 - dateOfBirthYear;
//if (age > 18)
//{
//    hasLicense = true;
//}
//else
//{
//    hasLicense = false;
//}

//if (hasLicense)
//{
//    WriteLine("Siz maşın sürə bilərsiniz");
//}
//else
//{
//    WriteLine("Sizin sürücülük vəsiqəniz yoxdur!");
//}

// Verilmiş ədədin tək və ya cüt olmasını tapan proqram yazın

//int number = 10; // 10 / 2 => qaliq sifirdir 
//// 10 % 2 == 0; -> eded cutdur

//if (number % 2 == 0 && number != 0)
//{
//    WriteLine($"{number} ədədi cütdür!");
//}
//else
//{
//    WriteLine($"{number} ədədi təkdir!");
//}






#endregion

#region Else-if Statements
//int number = 10; // 10 / 2 => qaliq sifirdir 
// 10 % 2 == 0; -> eded cutdur

//if (number % 2 == 0 && number != 0)
//{
//    WriteLine($"{number} ədədi cütdür!");
//}

//if (number == 0)
//{
//    WriteLine($" Ədəd Sıfırdır!");
//}


//if(number != 0  && number % 2 != 0)
//{
//    WriteLine($"{number} ədədi təkdir!");
//} ❌

//int number = 10;
//if (number != 0 && number % 2 == 0)
//{
//    WriteLine($"{number} ədədi cütdür!");
//}
//else if (number != 0 && number % 2 != 0)
//{
//    WriteLine($"{number} ədədi təkdir!");
//}
//else
//{
//    WriteLine("Ədəd sıfıra bərabərdir!");
//}
//Write("Type your User name : ");
//string userName = ReadLine();

//Write("Type your role");
//string role = ReadLine();

//if (userName == "boolean")
//{
//    if (role == "admin")
//    {
//       WriteLine("Admin sistemə daxil oldu!");
//    }
//    else if (role == "payrol")
//    {
//        WriteLine("Payrol sistemə daxil oldu!");
//    }
//    else if (role == "user")
//    {
//        WriteLine("User sistemə daxil oldu");
//    }

//}
//else
//{
//    WriteLine("User name dəyəri doğru deyildir!");
//}

//int accountBalance = 2000;

//Write("Your WithDrawal : ");

//int withDrawal = ToInt32(ReadLine());


//if (accountBalance >= withDrawal && withDrawal  > 0)
//{
//    accountBalance = accountBalance - withDrawal;
//}
//WriteLine(accountBalance);

//Write("Temprature : ");
//int temprature = ToInt32(ReadLine());

//if (temprature > -60 && temprature < 100)
//{
//    if (temprature >= 20 && temprature < 100)
//    {
//        WriteLine("Hava çox istidir");
//    }
//    else if (temprature >= 0 && temprature < 20)
//    {
//        WriteLine("Hava  istidir");
//    }
//    else if (temprature > -20 && temprature < 0)
//    {
//        WriteLine("Hava soyuqdur");
//    }
//    else
//    {
//        WriteLine("Hava buz kimidir :(");
//    }
//}


#endregion

#region Ternary Operators

//int temprature = -10;
////string msg = string.Empty;
////if (temprature >= 0)
////{
////    msg = "HOT";
////}
////else
////{
////    msg = "COLD";
////}  👇👇👇👇
//             //Condition       True   False
//string msg = temprature > 0 ? "HOT" : "COLD";



//int age = 10;
//string message = age > 18 ? "Siz maşın sürə bilərsiniz" : "Sizin sürücülük vəsiqəniz yoxdur";

//WriteLine(message);
////if (age > 18)
////{
////    hasLicense = true;
////}
////else
////{
////    hasLicense = false;
////} ❎


//Console.WriteLine(msg);

#endregion

#region Switch Case

//string roleName = "payrol";

//switch (roleName)
//{

//    case "admin":
//        WriteLine("Admin sistemə daxil oldu");
//        break;
//    case "user":
//        WriteLine("User sistemə daxil oldu");
//        break;
//    case "payrol":
//        WriteLine("Payrol sistemə daxil oldu");
//        break;
//    default:
//        break;
//}


//int number = 0;

//switch (number)
//{
//    case > 0:
//        WriteLine("Ədəd sıfırdan böyükdür");
//        break;
//    case < 0:
//        WriteLine("Ədəd mənfidir");
//        break;
//    default:
//        WriteLine("Ədəd sıfıra bərabərdir");
//        break;
//}

Write("Day : ");
int dayOfWeek = ToInt32(ReadLine());

string dayName = string.Empty;

if (dayOfWeek > 0 && dayOfWeek <= 7)
{
    switch (dayOfWeek)
    {
        case 1:
        case 3:
            WriteLine("GYM Day!");
            break;
        case 2:
        case 4:
            WriteLine("Programming Day");
            break;
        case 5:
            WriteLine("Movie day");
            break;
        case 6:
        case 7:
            WriteLine("Rest day!");
            break;
    }

    dayName = dayOfWeek switch
    {
        1 => "Bazar ertəsi",
        2 => "Çərşənbə Axşamı",
        3 => "Çərşənbə",
        _ => "Digər günlər"
    };
}


WriteLine(dayName);
#endregion