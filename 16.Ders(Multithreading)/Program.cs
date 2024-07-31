


//Thread thread1 = new Thread(RunThreadOne);
//thread1.Start();

//void RunThreadOne()
//{
//    for (int i = 0; i < 1000; i++)
//    {
//        Console.Write("1");
//    }
//}

//for (int i = 0;i < 1000; i++)
//{
//    Console.Write("0");
//}


//Thread thread1 = new Thread(() =>
//{
//    for (int i = 0; i < 100; i++)
//    {
//        Console.WriteLine($"Thread One => {i}");
//        Thread.Sleep(1000);
//    }
//});


//Thread thread2 = new Thread(() =>
//{
//    for (int i = 0; i < 100; i++)
//    {
//        Console.WriteLine($"Thread Two => {i}");
//    }
//});

//thread1.Start();
////thread1.Join();

//thread2.Start();


//int index = 3;
//object _lock = new object();

//Thread thread1 = new(() =>
//{

//    lock (_lock)
//    {
//        while (index <= 10)
//        {

//            index++;
//            Console.WriteLine($"Thread One => {index}");
//        }
//    }
//});


//Thread thread2 = new(() =>
//{
//    lock (_lock)
//    {
//        while (index > 0)
//        {
//            index--;
//            Console.WriteLine($"Thread Two => {index}");
//        }
//    }
//});

//thread1.Start();
//thread2.Start();



//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("X");
//}
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Y");
//}


//Task task = Task.Run(() =>
//{
//    Console.WriteLine("Boolean Teach");
//});

//Task task2 = Task.Run(() =>
//{
//    Console.WriteLine("Boolean Teach -1");
//});

//Task task3 = Task.Run(() =>
//{
//    Console.WriteLine("Boolean Teach -2");
//});

//Task task4 = Task.Run(() =>
//{
//    Console.WriteLine("Boolean Teach -3");
//});

//Task task5 = Task.Run(() =>
//{
//    Console.WriteLine("Boolean Teach - 4");
//});


// Task.WaitAll(task, task2, task3, task4, task5);

//var allTask = Task.WhenAll(task,task2,task3,task4,task5);


//allTask.GetAwaiter().GetResult();

//Task.Delay(1000);
//Task<int> task1 = Task.Run(() =>
//{
//    return 10;
//});



string path = @"C:\Users\ASUS\Documents\SubFolderA";

await Task.WhenAll(ReadDataFromFileAsync("File1.txt"), ReadDataFromFileAsync("File2.txt"), ReadDataFromFileAsync("File3.txt"));

async Task ReadDataFromFileAsync(string fileName)
{
    string fullPath =  Path.Combine(path, fileName);
    string text = await File.ReadAllTextAsync(fullPath);
    Console.WriteLine(text);
}
