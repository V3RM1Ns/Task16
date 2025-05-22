namespace Task16;
public class Celsius
{
    public double Degree { get; set; }
    public static implicit operator Celsius(Kelvin kelvin)
    {
        return new Celsius { Degree = kelvin.Degree - 273 };
    }
}
public class Kelvin
{
    public double Degree { get; set; }
    public static implicit operator Kelvin(Celsius celsius)
    {
        return new Kelvin { Degree = celsius.Degree + 273 };
    }
}