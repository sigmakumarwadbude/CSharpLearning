
using CSharpLearning.Employees;
using CSharpLearning.Departments;

// Create Employee objects
Employee employee = new(
    101,
    1,
    "Sigma Wadbude",
    "sigma@example.com",
    120000
);

Employee employeeWithPhone = new(
    102,
    1,
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
Console.WriteLine("========== EMPLOYEE INFORMATION ==========");

DisplayEmployee(employee);

Console.WriteLine();

DisplayEmployee(employeeWithPhone);

// Display Department information
Console.WriteLine();
Console.WriteLine("========== DEPARTMENT INFORMATION ==========");

Console.WriteLine($"Department ID   : {department.Id}");
Console.WriteLine($"Department Name : {department.Name}");
Console.WriteLine($"Location        : {department.Location}");
Console.WriteLine($"Description     : {department.Description}");

// Local function for displaying employee information
static void DisplayEmployee(Employee employee)
{
    Console.WriteLine($"Employee ID   : {employee.Id}");
    Console.WriteLine($"Department ID : {employee.DepartmentId}");
    Console.WriteLine($"Employee Name : {employee.Name}");
    Console.WriteLine($"Email         : {employee.Email}");
    Console.WriteLine($"Salary        : {employee.Salary:C}");

    Console.WriteLine(
        $"Phone Number  : {employee.PhoneNumber ?? "Not provided"}"
    );
}
