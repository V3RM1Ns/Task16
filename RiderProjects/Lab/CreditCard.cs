namespace Lab;

public class CreditCard:Card
{
    public int TotalWithdraw { get; set; }
    private int _limit { get; set; }
    public int Limit
    {
        get => Limit;
        set
        {
            if (value>0)
            {
                _limit = value;
            }
            else
            {
                throw new ArgumentException("Limit must be positive");
            }
        }
    }

    public override bool Withdraw(int amount)
    {
        TotalWithdraw += amount;
        if (amount <= Balance)
        {
            Balance -= amount;
        }
        else
        {
            if (_limit + Balance >= amount)
            {
                //200--100-500
                amount -= Balance;
                _limit -= amount;
            }
            else
            {
                throw new ArgumentException("Not enough money");
            }
        }
        return true;
    }

    public override string ToString()
    {
        return $"Balance{Balance}, Limit{Limit}, Bonus{Bonus},Id{Id}";
    }
}