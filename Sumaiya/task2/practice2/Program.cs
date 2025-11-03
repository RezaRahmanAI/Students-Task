// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var evenNumbers = from n in Enumerable.Range(1, 100)
                          where n % 2 == 0
                          select n;

        Console.WriteLine("Even Numbers from 1 to 100:");
        foreach (var n in evenNumbers)
            Console.Write(n + " ");
    }
}
