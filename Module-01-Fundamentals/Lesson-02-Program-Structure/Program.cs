
using CSharpLearning.Employees;
using CSharpLearning.Departments;

namespace CSharpLearning.Lesson02;

internal class Program
{
    static void Main(string[] args)
    {
        // Create Employee objects
        Employee employee = new(
            101,
            1, // DepartmentId
            "Sigma Wadbude",
            "sigma@example.com",
            120000
        );

        Employee employeeWithPhone = new(
            102,
            1, // DepartmentId
            "John Doe",
            "john@example.com",
            130000,
            "9876543210"
        );

        // Create Department object
        Department department = new(
            1,
            "Software Engineering",
            "Pune",
            "Responsible for software development and maintenance"
        );        

        // Display Employee information
        DisplayEmployee(employee);
        DisplayEmployee(employeeWithPhone);
    }

    private static void DisplayEmployee(Employee employee)
    {
        Console.WriteLine($"Employee ID   : {employee.Id}");
        Console.WriteLine($"Department ID : {employee.DepartmentId}");
        Console.WriteLine($"Employee Name : {employee.Name}");
        Console.WriteLine($"Email         : {employee.Email}");
        Console.WriteLine($"Salary        : {employee.Salary:C}");
        Console.WriteLine(
            $"Phone Number  : {employee.PhoneNumber ?? "Not provided"}");
    }
}
