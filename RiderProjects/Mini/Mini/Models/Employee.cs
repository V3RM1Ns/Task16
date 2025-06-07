namespace Mini.Models;

public class Employee
{
    public static int last { get; set; }
    public string FullName { get; set; }
    
    string _position { get; set; }
    public string Position
    {
        get=>_position;

        set
        {
            if (value.Length < 2)
                throw new ArgumentException($"Position \"{value}\" is too short. Min allowed length is 2.");
            _position = value;

        }
    }
    
    double _salary { get; set; }
    public double Salary
    {
        get=>_salary;
        set
        {
            if (value<250)
                throw new ArgumentException($"Salary \"{value}\" have to be more than 250.");
            _salary = value;
        }
    }
    
    public string DepartmentName { get; set; }
    
}