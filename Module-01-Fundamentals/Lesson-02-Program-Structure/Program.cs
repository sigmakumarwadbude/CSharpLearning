
using CSharpLearning.Lesson02.Models;

namespace CSharpLearning.Lesson02;

internal class Program
{
    // Application entry point
    static void Main(string[] args)
    {
        // Application information
        string applicationName = "CSharpLearning";

        // Read developer name from command-line arguments
        string developerName = args.Length > 0
            ? string.Join(" ", args)
            : "Unknown Developer";

        // Learning information
        string learningModule = "Module 01 - Fundamentals";

        string learningObjective =
            "Master C# 14 and .NET 10 to become an Angular + .NET Full Stack Developer";

        // Create Developer object
        Developer developer = new(
            developerName,
            "Angular + .NET Full Stack Developer",
            learningModule,
            learningObjective
        );

        // Display application information
        Console.WriteLine("==============================================");
        Console.WriteLine("             APPLICATION INFORMATION         ");
        Console.WriteLine("==============================================");

        Console.WriteLine($"Application Name : {applicationName}");
        Console.WriteLine($"Developer Name   : {developer.Name}");
        Console.WriteLine($"Developer Role   : {developer.Role}");
        Console.WriteLine($"Current Date     : {developer.CreatedAt:MMMM dd, yyyy}");

        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("               LEARNING DETAILS               ");
        Console.WriteLine("----------------------------------------------");

        Console.WriteLine($"Learning Module  : {developer.LearningModule}");
        Console.WriteLine("Learning Objective:");

        Console.WriteLine(developer.LearningObjective);

        Console.WriteLine("==============================================");
        Console.WriteLine("Welcome to C# 14 and .NET 10 Learning!");
        Console.WriteLine("==============================================");
    }
}
