// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
using System.Security.Principal;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        // Loading Screen
        Console.WriteLine("Loading...");
        for (int i = 0; i <= 100; i++)
        {
            Console.Write("\r{0}%", i);
            Thread.Sleep(50);
        }
        Console.WriteLine("\nLoading completed!");
        Thread.Sleep(60);
        Console.Clear();

        // Welcome
        WindowsIdentity currentUser = WindowsIdentity.GetCurrent();
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, {currentUser.Name}, on {currentDate:d} at {currentDate:t}!");
        
        // Input

        Start:
        Console.Write("Enter a command: ");
        string input = Console.ReadLine();
            
            //help
        if (input.ToLower() == "help")
        {
            Console.WriteLine("This is help.");
            goto Start;
        }
            //exit
        else if (input.ToLower() == "exit")
        {
            // Exit
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
            //invalider
        else
        {
            Console.WriteLine($"Hey, {currentUser.Name}! Did you read help? Go and try it!");
            goto Start;
        }

    }

}

