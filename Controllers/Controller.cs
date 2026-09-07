using System;
using System.Text;
using CSConsoleProject.Models;

namespace CSConsoleProject.Controllers;

public class Controller
{
    public void TypeWriterEffect(string? message, int time, TypeWriterMode mode = TypeWriterMode.NewLine)
    {
        if (message == null)
        {
            Console.WriteLine("No message provided!");
            return;
        }

        switch (mode)
        {
            case TypeWriterMode.OverwriteLine:
                int currentLineCursor = Console.CursorTop;
                Console.SetCursorPosition(0, currentLineCursor);
                Console.Write(new string(' ', Console.WindowWidth - 1));
                Console.SetCursorPosition(0, currentLineCursor);
            break;
            case TypeWriterMode.NewLine:
                Console.WriteLine();
            break;
            case TypeWriterMode.Append:
                // keep the current cursor position
            break;
        }

        foreach(char c in message)
        {
            Console.Write(c);
            Thread.Sleep(time);
        }
    }

    public static void Error(StringBuilder message, params LogCategory[] category)
    {
        message = new StringBuilder
        {
            
        };

        Console.WriteLine(message.ToString(), category);
        // log error message with a specific error color and logcategory.
    }
}