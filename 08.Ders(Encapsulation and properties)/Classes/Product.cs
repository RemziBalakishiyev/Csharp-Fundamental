namespace _08.Ders_Encapsulation_and_properties_.Classes;

internal class Product
{


    public string Id { get; private set; } = Guid.NewGuid().ToString();
    public string ProductName { get; set; }
    private double price;

    public double Price
    {
        set
        {
            if (value < 100 || value > 12000)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new ArgumentException("Qiymət 100 ilə 12000 arasında olmalıdır");
            }
            price = value;
        }
    }

    public double SalesPrice
    {
        get
        {
            return price + (price * 0.2);
        }
    }

    public int OrderDate { get; init; }

}
