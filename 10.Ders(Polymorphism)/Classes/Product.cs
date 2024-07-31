namespace _10.Ders_Polymorphism_.Classes;

internal class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual void DisplayInfo() => Console.WriteLine("Product message");
}
