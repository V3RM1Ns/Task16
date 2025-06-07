namespace task19new;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Employee> Employees { get; set; }

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }

    public Employee GetEmployeeById(int Id)
    {
        return Employees.Find(x => x.Id == Id);
    }

    public void RemoveEmployee(int id)
    {
        Employees.Remove(GetEmployeeById(id));
    }
}