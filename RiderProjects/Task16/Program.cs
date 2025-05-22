namespace Task16;

class Program
{
    static void Main(string[] args)
    {
      
        
        //Degree Task Start
        Celsius c = new Celsius { Degree = 25 };
        Kelvin k = c;
        Console.WriteLine(k.Degree);
        Kelvin z = new Kelvin { Degree = 232 };
        Celsius y = z;
        Console.WriteLine(y.Degree);
        //Degree Task End

        Console.WriteLine("press any key to continue");
        Console.ReadKey();
        Console.Clear();
        
        //Exchange Task Start
        Console.WriteLine("Enter the value you wont to exchange:");
        double Azn = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        double a = Exchange(Currency.Try, Azn);
        Console.WriteLine($"{Azn} Azn = {a} Try");
        
        double b = Exchange(Currency.Usd, Azn);
        Console.WriteLine($"{Azn} Azn = {b} Usd");

        double q = Exchange(Currency.Eur, Azn);
        Console.WriteLine($"{Azn} Azn = {q} Eur");
        //Exchace Task End
    }
    
    
    
    
    
    public static double Exchange(Enum currency, double azn)
    {
        if (azn == 0)
        {
            throw new Exception("ProductCountIsZeroException");
        }
        if (currency is not Currency)
            throw new Exception("Invalid enum type. Must be of type Currency.");
        switch ((Currency)currency)
        {
            case Currency.Usd:
                return azn * 0.59;
            case Currency.Eur:
                return azn * 0.54;
            case Currency.Try:
                return azn * 19.75;
            default:
                throw new Exception("NotFoundException");
        }
    }
}