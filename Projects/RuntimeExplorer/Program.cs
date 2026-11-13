
Console.WriteLine("==================================");
Console.WriteLine("       .NET RUNTIME EXPLORER      ");
Console.WriteLine("==================================");

// Display framework information
Console.WriteLine($"Framework: {System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}");

// Display operating system
Console.WriteLine($"OS: {System.Runtime.InteropServices.RuntimeInformation.OSDescription}");

// Display process architecture
Console.WriteLine($"Architecture: {System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture}");

// Display current runtime version
Console.WriteLine($"Runtime Version: {Environment.Version}");

// Display application information
Console.WriteLine($"Application: {AppDomain.CurrentDomain.FriendlyName}");

Console.WriteLine("==================================");
Console.WriteLine("Application executed successfully!");
