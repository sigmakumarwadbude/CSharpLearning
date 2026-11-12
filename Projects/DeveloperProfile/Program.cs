using DeveloperProfile.Models;

// Application information
string applicationName = "Developer Profile CLI";
string applicationVersion = "2.0";

// Read developer name from command-line arguments
string developerName = args.Length > 0 &&
                       !string.IsNullOrWhiteSpace(args[0])
    ? string.Join(" ", args)
    : "Unknown Developer";

// Developer information
string developerRole = "Angular + .NET Full Stack Developer";

string learningObjective =
    "Master C# 14 and .NET 10 to build enterprise-grade full-stack applications";

// Create Developer object
Developer developer = new(
    developerName,
    developerRole,
    learningObjective
);

// Display developer profile
Console.WriteLine();
Console.WriteLine("================================================");
Console.WriteLine("              DEVELOPER PROFILE                 ");
Console.WriteLine("================================================");

Console.WriteLine($"Application  : {applicationName}");
Console.WriteLine($"Version      : {applicationVersion}");

Console.WriteLine("------------------------------------------------");

Console.WriteLine($"Name         : {developer.Name}");
Console.WriteLine($"Role         : {developer.Role}");
Console.WriteLine($"Created Date : {developer.CreatedAt:dd MMMM yyyy}");

Console.WriteLine("------------------------------------------------");

Console.WriteLine("LEARNING OBJECTIVE");
Console.WriteLine(developer.LearningObjective);

Console.WriteLine("================================================");
Console.WriteLine("       Welcome to Developer Profile CLI!        ");
Console.WriteLine("================================================");
