using static System.Console;
using static System.Convert;




#region While Loops
// Dövr verilən prosesi verilən şərt üzərində təkrar etməsidir.


//int index = 0;
//while (index < 5)
//{
//    WriteLine("Loop is work!");
//    index = index + 1; // i = 0 +1 -> i = 1 , i = 1 + 1 -> i =  2
//    WriteLine($"Index = {index}");
//}

//WriteLine("Loop was completed!");




//string secretWord = "";
//int countOfWrong = 0;
//while (secretWord != "boolean")
//{
//    Write("type your secret word : ");
//    secretWord = ReadLine();
//    countOfWrong = countOfWrong + 1;
//}


//WriteLine("You found Secret word");

//WriteLine($"Your count of repeat : {countOfWrong}");


#endregion

#region Do While
//string secretWord = "";
//int countOfWrong = 0;
//while (secretWord != "boolean")
//{
//    countOfWrong = countOfWrong + 1;
//    Write("type your secret word : ");
//    secretWord = ReadLine();

//}

// Do While dövrü while dövründən fərqli olaraq əməliyyatı şərti yoxlamadan ən az bir dəfə icra edir
//int countOfWrong = 0;
//string secretWord;
//do
//{
//    Write("type your secret word : ");
//    secretWord = ReadLine();
//    countOfWrong++;
//} while (secretWord != "boolean");

//WriteLine("You found Secret word");

//WriteLine($"Your count of repeat : {countOfWrong}");
#endregion

#region For Loop

//int index = 1;

//while (index<=5)
//{
//    WriteLine(index);
//    index++;

//}

// İterasiyalı əməliyyatlarda for istifadə etmək daha məqsədə uyğundur.

//for (int index = 1; index <= 5; index++)
//{
//    WriteLine("For Loop is work! index = {0}",index);
//}
// 1 -  le 10 arasinda ədədləri göstər
//for (int index = 1; index <= 10; index++)
//{
//    WriteLine($"{index}");
//}

#endregion

#region Break , Continue and Go to
// break dövrü dayandırmaq üçün istifadə olunur. 
//while (true)
//{
//    Write("Number: ");
//    int number = ToInt32(ReadLine());

//    if(number == 5)
//    {
//        break;
//    }

//}

//for (int i = 0; i < 10; i++)
//{

//    if (i == 7)
//    {
//        continue;   
//    }
//    WriteLine(i);
//}

//WriteLine("Breaking loop");
OutputEncoding = System.Text.Encoding.UTF8;

//returnpast;
//WriteLine("Əməliyyatları edin ");
//WriteLine("1. Bitirin  ");
//WriteLine("2. Geri qayıdın  ");


//int operationName = ToInt32(ReadLine());

//if (operationName == 1)
//{
//    WriteLine("Əməliyyat bitdi");
//}
//else
//{
//    goto returnpast;
//}


#endregion

#region Nested For Loops
// Outer dövrün hər bir dövründə inner bütün dövrlərini tamamlayır.
//for (int outer = 1; outer <= 3; outer++)
//{
//    for (int inner = 1; inner <= 5; inner++)
//    {
//        WriteLine($"outer = {outer} -- inner = {inner}");
//    }
//}



#endregion

#region Practice

#region While Practice





#endregion

#region For Practice 
// -10-la  20 arasinda 5 artimla  ededlerin cəmini tapın 


//int sum = 0;
//for (int index = 10; index >= -20; index--)
//{
//    WriteLine(index);
//    sum += index;
//}
//WriteLine(sum);

// 1 -  lə 100 arasında cüt ədədləri tapın.

//for (int index = 1; index <= 100; index++)
//{
//    if(index % 2 == 0 || index % 5 ==0)
//    {
//        WriteLine(index);
//    }
//}
#endregion


#region Nested For Loop

//1. Vurma cədvəli yaradın

//for (int outer = 1; outer <= 9; outer++)
//{
//    for (int inner = 1; inner < 9; inner++)
//    {
//        WriteLine($"{outer} * {inner} = {outer * inner}");
//    }
//    WriteLine("-------------");
//}


//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Write("*  ");
//    }
//    WriteLine();
//}

#endregion
#endregion
