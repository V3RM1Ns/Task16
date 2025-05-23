namespace Lab;

public abstract class Card
{
    public int Id { get; set; }
    public int Balance { get; set; }
    public int Bonus { get; set; }
    public long _cardNumber { get; private set; }
    public long CardNumber
    {
        get => _cardNumber;
        set
        {
            string b= value.ToString();
            if (b.Length == 16)
            {
                _cardNumber = value;
            }
            else
            {
                throw new ArgumentException("Card number must be 16 digits");
            }
        }
    }

    enum Bank
    {
        Kapital,
        Leo,
        Abb
    }

    public abstract bool Withdraw(int amount);
}