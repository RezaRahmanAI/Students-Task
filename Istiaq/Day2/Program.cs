using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        var student = new Student { Name = "Rizve", Roll = 101, Marks = 85 };
        Console.WriteLine($"GPA: {student.CalculateGPA()}");

        var evenNumbers = Enumerable.Range(1, 100).Where(n => n % 2 == 0);
        Console.WriteLine("Even numbers from 1 to 100:");
        foreach (var num in evenNumbers) Console.Write($"{num} ");
        Console.WriteLine();

        await ShowLoadingAsync();

        EmployeeRecord emp = new EmployeeRecord("Rahim", "IT", 50000);
        object input1 = 42;
        object input2 = "Hello";
        object input3 = emp;

        DisplayType(input1);
        DisplayType(input2);
        DisplayType(input3);
    }

    public static async Task ShowLoadingAsync()
    {
        Console.WriteLine("Loading...");
        await Task.Delay(2000);
        Console.WriteLine("Loaded!");
    }

    public static void DisplayType(object obj)
    {
        switch (obj)
        {
            case int i:
                Console.WriteLine($"Integer: {i}");
                break;
            case string s:
                Console.WriteLine($"String: {s}");
                break;
            case EmployeeRecord e:
                Console.WriteLine($"Employee: {e.Name}, {e.Department}, {e.Salary}");
                break;
            default:
                Console.WriteLine("Unknown type");
                break;
        }
    }
}

public class Student
{
    public string Name { get; set; }
    public int Roll { get; set; }
    public int Marks { get; set; }

    public double CalculateGPA()
    {
        return Marks / 20.0;
    }
}

public record EmployeeRecord(string Name, string Department, double Salary);
