
namespace DeveloperProfile.Models;

public class Developer
{
    // Developer information
    public string Name { get; set; }

    public string Role { get; set; }

    public string LearningObjective { get; set; }

    // Profile creation date
    public DateTime CreatedAt { get; } = DateTime.Now;

    // Constructor
    public Developer(
        string name,
        string role,
        string learningObjective)
    {
        Name = name;
        Role = role;
        LearningObjective = learningObjective;
    }
}
