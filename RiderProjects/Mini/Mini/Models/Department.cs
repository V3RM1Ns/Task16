namespace Mini.Models;

public class Department
{
    string _name { get; set; }
    public string Name
    {
        get=>_name;
        set
        {
            if(value.Length<2)
                throw new ArgumentException("Name must be at least 2 characters");
            _name = value;
        }
    }

    int _workerLimit { get; set; }
    public int WorkerLimit
    {
        get => _workerLimit;
        set
        {
            if (value<1)
                throw new ArgumentException("Worker limit must be at least 1");
            _workerLimit = value;
        }
    }

    private int _salaryLimit { get; set; }
    public int SalaryLimit
    {
        get => _salaryLimit;
        set
        {
            if (value<250)
                throw new ArgumentException("Salary limit must be at least 250");
            _salaryLimit = value;
        }
    }
    
    public List<Employee> Employees { get; set; }

    public int CalcSalaryAvarage()
    {
       return _salaryLimit/_workerLimit;
    }
}