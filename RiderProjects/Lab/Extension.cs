namespace Lab;

public static class Extension
{
    public static string MaskCardNumber(this Card card)
    {
       string a=card._cardNumber.ToString();
        string first4 = a.Substring(0, 4);
        string last4 =a.Substring(12, 4);

        return $"{first4} **** **** {last4}";
    }
}