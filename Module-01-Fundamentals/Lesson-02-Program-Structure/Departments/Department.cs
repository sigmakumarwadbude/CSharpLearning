
namespace CSharpLearning.Departments;

public class Department
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Location { get; set; }

    public string Description { get; set; }

    public Department(
        int id,
        string name,
        string location,
        string description = "")
    {
        Id = id;
        Name = name;
        Location = location;
        Description = description;
    }
}
