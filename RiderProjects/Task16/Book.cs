namespace Task16;

public class Book : Product
{
    public string AuthorName { get; set; }
    public int PageCount { get; set; }
    private static int _nextId = 1;  
    public int Id { get; }

    public Book(string authorName, int pageCount, double price, string name)
        : base(name, price)
    {
        AuthorName = authorName;
        PageCount = pageCount;
        Id = _nextId++;
    }

    public override void Sell()
    {
        if (Count == 0)
            throw new Exception("ProductCountIsZeroException");

        TotalIncome += Price;
        Count--;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Author: {AuthorName}, Page Count: {PageCount}, Name: {Name}, " +
                          $"Price: {Price}, Income: {TotalIncome}, Id: {Id}, Count: {Count}");
    }
}
