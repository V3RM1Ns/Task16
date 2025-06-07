namespace task19new;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name} Salary: {Salary} Id: {Id}");
    }
}