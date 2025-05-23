namespace Lab;

public class DebitCard:Card
{
    public int TotalWithdraw { get; set; }
    public override bool Withdraw(int amount)
    {
        TotalWithdraw += amount;
        if (amount>Balance)
            throw new ArgumentException("Not enough money");
        if (amount>=Balance)
        {
            Balance -= amount;
        }
        return true;
    }
    public override string ToString()
    {
        return $"Balance{Balance}, Bonus{Bonus},Id{Id}";
    }
}