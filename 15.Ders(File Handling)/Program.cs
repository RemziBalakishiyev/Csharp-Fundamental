using _15.Ders_File_Handling_;
using Microsoft.VisualBasic.FileIO;
using System.Text;
using static System.Console;
OutputEncoding = System.Text.Encoding.UTF8;
string folderAddres = @"C:\Users\ASUS\Documents\Test folder";


string fileName = "Boolean.txt";
string fullPath = Path.Combine(folderAddres, fileName);
string fullPath2 = Path.Combine(folderAddres, "Bool.txt");
string peoplePath = Path.Combine(folderAddres, "People.txt");
#region Path
//WriteLine(fullPath);


//WriteLine($"{fullPath} file'nin içində olduğu Folder : {Path.GetDirectoryName(fullPath)}");
//WriteLine($"{folderAddres} file'nin içində olduğu Folder : {Path.GetDirectoryName(folderAddres)}");
//WriteLine($"{Path.GetFileName(fullPath)} file'nin içində olduğu Folder : {Path.GetDirectoryName(fullPath)}");
//WriteLine($"{Path.GetFileNameWithoutExtension(fullPath)} file'nin içində olduğu Folder : {Path.GetDirectoryName(fullPath)}");

//WriteLine($"{Path.GetFileNameWithoutExtension(fullPath)} file'nin extension'u {Path.GetExtension(fullPath)}");

//string randomFileName =  Path.GetRandomFileName();

//WriteLine($"Random File Name : {randomFileName}");

//string newRandomFileName = randomFileName.Substring(randomFileName.IndexOf("."),4);
//newRandomFileName = randomFileName.Replace(newRandomFileName, ".txt");


//WriteLine(newRandomFileName);

//WriteLine(Path.ChangeExtension(fullPath, ".csv"));

#endregion
#region Directory
//WriteLine(Path.Combine(folderAddres, "New Folder By C#"));

//Directory.CreateDirectory(Path.Combine(folderAddres, "SubFolderB"));


//WriteLine();
//if (Directory.Exists(Path.Combine(folderAddres, "SubFolderB")))
//{
//    Directory.Delete(Path.Combine(folderAddres, "SubFolderB"));
//}


//string[] files = Directory.GetFiles(folderAddres);

//foreach (string file in files)
//{
//    if (Path.GetExtension(file) != ".txt")
//    {
//        WriteLine($"File => {Path.GetFileName(file)}");
//    }
//}


//string[] directories = Directory.GetDirectories(folderAddres);

//foreach (string directory in directories)
//{
//    WriteLine($"Directory => {directory}");
//} 
#endregion


WriteLine(SpecialDirectories.Desktop);


//WriteLine(File.ReadAllText(fullPath));

//File.AppendAllText(fullPath, ". Həmçinin 5 ildirki proqramçı olaraq çalışıram");


//string[] lines = File.ReadAllLines(fullPath2);

//foreach (string line in lines)
//{
//    Console.WriteLine($"Line => {line}");
//}

//string[] lines = { "Line 1", "Line 2", "Line 3" };
//File.WriteAllLines(fullPath2, lines);


//string[] lines = { "4.Teyyar", "5. Aysel" };

//File.AppendAllLines(fullPath2, lines);
//using (FileStream fileStream = new FileStream(fullPath2, FileMode.Open, FileAccess.Read))
//{
//    byte[] bytes = new byte[1024];
//    int data = fileStream.Read(bytes, 0, bytes.Length);
//    string readData = Encoding.UTF8.GetString(bytes);
//    WriteLine(readData);
//}


//using (FileStream fileStream1 = new(fullPath,FileMode.Open,FileAccess.Write))
//{
//    string content = "New Content";
//    byte[] bytes = Encoding.UTF8.GetBytes(content);
//    fileStream1.Write(bytes, 0, bytes.Length);
//}

//using (StreamWriter writer = new StreamWriter(fullPath,true))
//{
//    writer.NewLine = "\r\n";
//    writer.WriteLine(" Hello world 2 ");
//}


//using (StreamReader reader = new StreamReader(fullPath))
//{
//    Console.WriteLine(reader.ReadToEnd());
//}

List<Person> people = new List<Person>
{
    new Person { Name="Bruce Wayne" },
    new Person { Name="Walter White" },
    new Person { Name="John Wick" },
};



using (StreamWriter personWriter = new StreamWriter(peoplePath,true))
{
    foreach (var person in people)
    {
        personWriter.WriteLine($"{person.Id} -- {person.Name}");
    }
}