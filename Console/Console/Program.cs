// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Loading...");
        for (int i = 0; i <= 100; i++)
        {
            Console.Write("\r{0}%", i);
            Thread.Sleep(50);
        }
        Console.WriteLine("\nLoading completed!");

        WindowsIdentity currentUser = WindowsIdentity.GetCurrent();
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, {currentUser.Name}, on {currentDate:d} at {currentDate:t}!");
        Console.Write($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey(true);
    }

}

