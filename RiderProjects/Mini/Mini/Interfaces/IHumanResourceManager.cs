using Mini.Models;

namespace Mini.Interfaces;

public interface IHumanResourceManager
{
    public void AddDepartment(Department department);
    public List<Department> GetDepartment();
    public void EditDepartment(string oldName, string newName);
    
    public void AddEmployee(Employee employee,string departmentName);
    public void RemoveEmployee(string employeeNo,string departmentName);
    public void EditEmployee(string no,string newSalary,string newPosition);
    public void Search(string searchString);
}

public class HumanResourceManager : IHumanResourceManager
{
    List<Department> _departments = new List<Department>();
    public void AddDepartment(Department department)
    {
        _departments.Add(department);
    }

    public List<Department> GetDepartment()
    {
        return _departments;
    }

    public void EditDepartment(string oldName, string newName)
    {
        var a= _departments.FirstOrDefault(x => x.Name == oldName);
        if (a != null)
        {
            a.Name = newName;
        }
    }

    public void AddEmployee(Employee employee,string departmentName)
    {
        var a = _departments.FirstOrDefault(x => x.Name == departmentName);
        if (a != null)
        {
            a.Employees.Add(employee);
        }
    }

    public void RemoveEmployee(string employeeNo, string departmentName)
    {
        Department department = _departments.FirstOrDefault(d => d.Name == departmentName);
        if (department != null)
        {
            Employee employee = department.Employees.FirstOrDefault(e => e. == no);
            if (employee != null)
            {
                department.Employees.Remove(employee);
            }
        }
    }
}