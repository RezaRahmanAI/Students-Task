using System;

namespace TypeMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPattern Matching Test:");
            ShowType(42);
            ShowType("Pisu");
            ShowType(3.14);
            ShowType(true);
        }

        // Pattern Matching Method
        static void ShowType(object input)
        {
            switch (input)
            {
                case int i:
                    Console.WriteLine($"{i} is an Integer.");
                    break;
                case string s:
                    Console.WriteLine($"\"{s}\" is a String.");
                    break;
                case double d:
                    Console.WriteLine($"{d} is a Double.");
                    break;
                case bool b:
                    Console.WriteLine($"{b} is a Boolean.");
                    break;
                default:
                    Console.WriteLine("Unknown type.");
                    break;
            }
        }
    }
}