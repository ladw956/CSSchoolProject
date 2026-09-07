using System;
using System.Text;
using CSConsoleProject.Models;
using CSConsoleProject.Controllers;

namespace CSConsoleProject;

public class Program
{
    Controller cont = new();

    private static void Main(string[] args)
    {
        Program app = new Program();
        app.Run();
    }

    private int Run()
    {
        Console.WriteLine("Hello User!");
        Console.WriteLine("");

        Console.Write("What's your name? ");
        string? userName = Console.ReadLine();
        if (string.IsNullOrEmpty(userName))
        {
            //Console.WriteLine("Sad... You don't have a name :(");
            cont.TypeWriterEffect("Sad... You don't have a name :(", 100);
            return 1;
        }

        string trimmedUsername = userName.ToLower();

        if (trimmedUsername == "john")
        {
            string message =
            "John? I hope you used your real name, " +
            "instead of something very standard :) ";

            cont.TypeWriterEffect(message, 20);

            Console.ReadKey();
            message = string.Empty;

            message = "Hope to see you again soon... ";

            cont.TypeWriterEffect(message, 80, TypeWriterMode.OverwriteLine);
            
            Console.ReadKey(true);
            Console.Write($"{userName}.");
            Console.ReadKey(true);

            Console.WriteLine(""); // End the previous line ending
            Console.WriteLine("Test_ending"); // Starts on new line
            Console.ReadKey(); // One final last key to press before end.

            return 0;
        }

        Console.WriteLine($"Hello {userName}.");
        return 0;
    }
}