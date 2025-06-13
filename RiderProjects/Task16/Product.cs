namespace Task16;

public abstract class Product
{
    public string Name { get; set; }
    public int Count { get; set; }
    public double Price { get; set; }
    public double TotalIncome { get; protected set; }
    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
    public abstract void Sell();
    public abstract void ShowInfo();
}
