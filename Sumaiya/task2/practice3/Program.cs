// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Loading...");
        await Task.Delay(2000);

        Console.WriteLine("Loaded!");
    }
}
