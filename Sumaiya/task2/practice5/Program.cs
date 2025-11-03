// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        object[] dataItems = { 2, "Hello", 0.01};

        foreach (var data in dataItems)
        {
            switch (data)
            {
                case int n:
                    Console.WriteLine($"Integer: {n}");
                    break;
                case string s:
                    Console.WriteLine($"String: {s}");
                    break;
                case double d:
                    Console.WriteLine($"Double: {d}");
                    break;
                
            }
        }
    }
}

