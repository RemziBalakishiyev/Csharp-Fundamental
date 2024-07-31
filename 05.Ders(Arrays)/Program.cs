#region Arrays
//string city1 = "Baku";
//string city2 = "Sumqayit";
//string city3 = "Masalli";

//string[] cities = { "Baku", "Sumqayit", "Masalli", "Lenkaran" };


//Console.WriteLine(cities[2]);
//string currentCity = cities[3];
//Console.WriteLine($"I live in {currentCity}");

//cities[1] = "Quba";

//Console.WriteLine(cities[1]);

//int[] numbers = new int[3];

//numbers[0] = 1;
//numbers[1] = 2;
//numbers[2] = 3;
////numbers[3] = 4;

//Console.WriteLine(numbers[2]);


//(int, string) mixedElement = (10, "Quba");

//(int, bool)[] scores = [(100, true), (50, false), (99, true)];



//Console.WriteLine(scores[1].Item1);

//Console.WriteLine(mixedElement.Item2);

//char[] characters = ['a', '@', '1', '&'];

//Console.WriteLine(characters[1]);


#endregion

#region For loop and Foreach loops
//string[] books = ["1984", "Crime and punishment", "Martin Eden"];

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine($"books[{i}] =>  {books[i]}");
//}

//int[] numbers = [1, 2, 4, 7, 9, 12, 13, 18];

//Console.WriteLine("Size of Array {0}", numbers.Length);

//for (int i = 0; i < numbers.Length; i++)
//{


//    if (numbers[i] % 2 == 0)
//    {
//        Console.WriteLine($"Even numbers[{i}] =>  {numbers[i]}");
//    }
//}

//string[] movies = new string[3];

//for (int i = 0; i < movies.Length; i++)
//{
//    Console.Write("Movie Name : ");
//    movies[i] = Console.ReadLine();
//}
//Console.WriteLine("--------------");

////var item = true;
////item = false;
////var item2 = new int[] { 1, 2, 3 };




//foreach (var movie in movies)
//{
//    Console.WriteLine("Movie: {0}",movie);
//}

//(string?, double)[] tvSeries = new (string?, double)[3];

//for (int i = 0; i < tvSeries.Length; i++)
//{
//    Console.Write("Write serie name: ");
//    tvSeries[i].Item1 = Console.ReadLine();
//    Console.Write("Imdb Point: ");
//    tvSeries[i].Item2 = Convert.ToDouble(Console.ReadLine());
//}

//foreach (var serie in tvSeries)
//{
//    if (serie.Item2 > 6.0)
//    {
//        Console.WriteLine($"Movie Name {serie.Item1} - IMDB : {serie.Item2}");
//    }
//}



#endregion

#region Array methods
//int[] numbers = [1, -4, 7, 9, -12, 2, 13, 18];
//Array.Sort(numbers);
//Array.Reverse(numbers);
//Array.Clear(numbers);

//Console.WriteLine(Array.IndexOf(numbers,-12));
//foreach (var num in numbers)
//{
//    Console.WriteLine(num);
//}

#endregion

#region Multidimensional Array

//int[,] twoDimensionalArr =
//{
//    { 1, 2, 3, 11 },
//    { 4, 5, 6, 12 },
//    { 7, 8, 9, 13 },
//};

//Console.WriteLine(twoDimensionalArr.GetLength(1));

//Console.WriteLine(twoDimensionalArr[2, 0]);


//for (int row = 0; row < twoDimensionalArr.GetLength(0); row++)
//{
//    for (int column = 0; column < twoDimensionalArr.GetLength(1); column++)
//    {
//        Console.WriteLine($"twoDimensionalArr[{row},{column}] => {twoDimensionalArr[row, column]}");
//        Console.Write($"{twoDimensionalArr[row, column]} \t");
//    }
//    Console.WriteLine();
//}




#endregion



#region Practice
int[] numbers = [1, 100, -30, 450, 6];

//Console.WriteLine(numbers.Max());
int maxNumber = numbers[0];
int maxNumIndex = 0;

for (int index = 0; index < numbers.Length; index++)
{
    if (maxNumber < numbers[index])
    {
        maxNumber = numbers[index];
        maxNumIndex = index;
    }
}
Console.WriteLine("Max number of array : {0} index : {1}",maxNumber,maxNumIndex);
#endregion