using CustomExtensions;
using System;

namespace ExtensionsMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string demo = "This is a demo";
            demo.PrintToConsole();

            SimpleLogger logger = new();
            logger.LogError("This is error");
        }
    }

    public static class ExtendSimpleLogger
    {
        public static void LogError(this SimpleLogger logger, string message)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            logger.Log(message, "Error");
            Console.ForegroundColor = defaultColor;
        }
    }

    public class SimpleLogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine(message);
        }

        public void Log(string message, string messageType)
        {
            Log($"{messageType}: {message}");
        }
    }
}
