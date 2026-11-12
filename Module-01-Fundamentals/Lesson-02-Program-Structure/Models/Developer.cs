namespace CSharpLearning.Lesson02.Models;

public class Developer
{
    // Developer information
    public string Name { get; set; }

    public string Role { get; set; }

    // Learning information
    public string LearningModule { get; set; }

    public string LearningObjective { get; set; }

    // Application creation date
    public DateTime CreatedAt { get; } = DateTime.Now;

    // Constructor
    public Developer(
        string name,
        string role,
        string learningModule,
        string learningObjective)
    {
        Name = name;
        Role = role;
        LearningModule = learningModule;
        LearningObjective = learningObjective;
    }
}
