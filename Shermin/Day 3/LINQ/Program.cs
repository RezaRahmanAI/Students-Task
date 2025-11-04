using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        var students = new List<Student>
        {
            new Student { Id = 1, Name = "Rizve", Age = 22, Marks = 85 },
            new Student { Id = 2, Name = "Rahim", Age = 20, Marks = 72 },
            new Student { Id = 3, Name = "Karim", Age = 23, Marks = 90 },
            new Student { Id = 4, Name = "Sonia", Age = 19, Marks = 65 },
            new Student { Id = 5, Name = "Lima", Age = 21, Marks = 95 }
        };

        // Exercise 1
        var ageOver20 = students.Where(s => s.Age > 20);
        Console.WriteLine("Students older than 20");
        foreach (var s in ageOver20)
            Console.WriteLine(s.Name);
      

        // Exercise 2
        var highMarks = students.Where(s => s.Marks >= 80);
        Console.WriteLine(" Students with Marks >= 80");
        foreach (var s in highMarks)
            Console.WriteLine(s.Name);
        

        // Exercise 3
        var sortedNames = students.OrderBy(s => s.Name);
        Console.WriteLine(" Names Alphabetically");
        foreach (var s in sortedNames)
            Console.WriteLine(s.Name);
        

        // Exercise 4
        Console.WriteLine("Maximum Marks:");
        var maxMarks = students.Max(s => s.Marks);
        Console.WriteLine( maxMarks);
       

        // Exercise 5
        Console.WriteLine("Print the avarage number ");
        var avgMarks = students.Average(s => s.Marks);
        Console.WriteLine(" Average Marks = " + avgMarks);

        // Exercise 6
        var youngest = students.OrderBy(s => s.Age).First();
        Console.WriteLine("Youngest Student = " + youngest.Name + " (Age " + youngest.Age + ")");
        

        // Exercise 7
        Console.WriteLine("Projection And group name");
        var idName = students.Select(s => new { s.Id, s.Name });
        foreach (var s in idName)
            Console.WriteLine($"Id: {s.Id}, Name: {s.Name}");
       

        // Exercise 8
        var namesStartingR = students.Where(s => s.Name.StartsWith("R"));
        Console.WriteLine(" Names starting with 'R'");
        foreach (var s in namesStartingR)
            Console.WriteLine(s.Name);
        

        // Exercise 9
        var grouped = students.GroupBy(s => s.Marks >= 80 ? "High Marks" : "Low Marks");
        Console.WriteLine("Exercise 9: Grouping by Marks");
        foreach (var group in grouped)
        {
            Console.WriteLine(group.Key + ":");
            foreach (var s in group)
                Console.WriteLine(" - " + s.Name);
        }
        Console.WriteLine();

        // Exercise 10
        var filtered = students.Where(s => s.Age > 20 && s.Marks >= 85);
        Console.WriteLine("Exercise 10: Age > 20 AND Marks >= 85");
        foreach (var s in filtered)
            Console.WriteLine(s.Name);
        Console.WriteLine();


    // exercise 11

   var top2Students = students
    .OrderByDescending(s => s.Marks) 
    .Take(2);                        

Console.WriteLine("Top 2 Students:");
foreach (var s in top2Students)
{
    Console.WriteLine($"Name: {s.Name}, Marks: {s.Marks}");
}



    }
}
