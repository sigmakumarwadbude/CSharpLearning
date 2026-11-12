namespace CSharpLearning.Employees;

public class Employee
{
    public int Id { get; set; }

    public int DepartmentId { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public decimal Salary { get; set; }

    public string? PhoneNumber { get; set; }

    public Employee(
        int id,
        int departmentId,
        string name,
        string email,
        decimal salary,
        string? phoneNumber = null)
    {
        Id = id;
        DepartmentId = departmentId;
        Name = name;
        Email = email;
        Salary = salary;
        PhoneNumber = phoneNumber;
    }
}
