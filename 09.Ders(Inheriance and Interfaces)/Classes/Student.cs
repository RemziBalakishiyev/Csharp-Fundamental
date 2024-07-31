using _09.Ders_Inheriance_and_Interfaces_.Interfaces;

namespace _09.Ders_Inheriance_and_Interfaces_.Classes;

internal class Student:Person,IPerson
{
    public Student(string message) : base(message)
    {
        Console.WriteLine("Student class is work!");
    }

    public Student():base("")
    {
        Console.WriteLine("Student class is work!");
    }

    private string grade;

    public string Grade
    {
        get { return grade; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Grade can't be null");
            }
            grade = value;
        }
    }

    public void FeedBackMessage()
    {
        Console.WriteLine("I am Student and I like this tutorials");
    }
}
