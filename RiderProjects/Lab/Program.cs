namespace Lab;

class Program
{
    static void Main(string[] args)
    {
        DebitCard card = new DebitCard();
        card.CardNumber=1234567890123456;
        Console.WriteLine(card.MaskCardNumber());
        
    }
}