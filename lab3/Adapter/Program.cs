using Adapter.classes;
using Adapter.interfaces;

Console.WriteLine("Console Logger:");
Logger consoleLogger = new Logger();
consoleLogger.Log("System started successfully");
consoleLogger.Warn("Low memory warning");
consoleLogger.Error("Critical error occurred");

Console.WriteLine("\nFile Logger:");
FileWriter fileWriter = new FileWriter("adapter.txt");
ILogger fileLogger = new FileLoggerAdapter(fileWriter);

fileLogger.Log("System started successfully");
fileLogger.Warn("Low memory warning");
fileLogger.Error("Critical error occurred");

Console.WriteLine("\nContents of adapter.txt:");
Console.WriteLine(File.ReadAllText("adapter.txt"));