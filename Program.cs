using System.Net.WebSockets;

Console.WriteLine("Hello from Docker!");
Console.WriteLine($"Hostname: {Environment.MachineName}");
Console.WriteLine($"OS: {System.Runtime.InteropServices.RuntimeInformation.OSDescription}");
int number = 1000;
while(true)
{
    Console.WriteLine($"{number}");
};