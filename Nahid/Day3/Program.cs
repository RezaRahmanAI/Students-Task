using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student { Id = 1, Name = "Rizve", Age = 22, Marks = 85 },
            new Student { Id = 2, Name = "Rahim", Age = 20, Marks = 72 },
            new Student { Id = 3, Name = "Karim", Age = 23, Marks = 90 },
            new Student { Id = 4, Name = "Sonia", Age = 19, Marks = 65 },
            new Student { Id = 5, Name = "Lima", Age = 21, Marks = 95 }
        };

        // ---------------------------
        // Exercise 1: 20 student
        // ---------------------------

        var ex1_query = from s in students
                        where s.Age > 20
                        select s;

        var ex1_method = students.Where(s => s.Age > 20);

        Console.WriteLine("Ex1: Age 20 > student:");
        foreach (var s in ex1_method)
            Console.WriteLine($"{s.Name} ({s.Age})");

        // ---------------------------
        // Exercise 2: Marks ≥ 80
        // ---------------------------

        var ex2_query = from s in students
                        where s.Marks >= 80
                        select s.Name;

        var ex2_method = students.Where(s => s.Marks >= 80)
                                 .Select(s => s.Name);

        Console.WriteLine("\nEx2: Marks ≥ 80:");
        Console.WriteLine(string.Join(", ", ex2_method));

        // ---------------------------
        // Exercise 3: Name Alphabetically sort
        // ---------------------------

        var ex3_query = from s in students
                        orderby s.Name
                        select s.Name;

        var ex3_method = students.OrderBy(s => s.Name)
                                 .Select(s => s.Name);

        Console.WriteLine("\nEx3: Name Alphabetically sort:");
        Console.WriteLine(string.Join(", ", ex3_method));

        // ---------------------------
        // Exercise 4: Higsht Mark
        // ---------------------------

        var ex4_query = (from s in students
                         select s.Marks).Max();

        var ex4_method = students.Max(s => s.Marks);

        Console.WriteLine($"\nEx4: Higsht Mark: {ex4_method}");

        // ---------------------------
        // Exercise 5: Average Mark
        // ---------------------------

        var ex5_query = (from s in students
                         select s.Marks).Average();

        var ex5_method = students.Average(s => s.Marks);

        Console.WriteLine($"\nEx5: Average Mark: {ex5_method:F2}");

        // ---------------------------
        // Exercise 6: minimum Age
        // ---------------------------

        var ex6_query = (from s in students
                         orderby s.Age
                         select s).First();

        var ex6_method = students.OrderBy(s => s.Age).First();

        Console.WriteLine($"\nEx6: younger: {ex6_method.Name} ({ex6_method.Age})");

        // ---------------------------
        // Exercise 7: Projection → only Id ও Name
        // ---------------------------

        var ex7_query = from s in students
                        select new { s.Id, s.Name };

        var ex7_method = students.Select(s => new { s.Id, s.Name });

        Console.WriteLine("\nEx7: Projection (Id, Name):");
        foreach (var s in ex7_method)
            Console.WriteLine($"Id: {s.Id}, Name: {s.Name}");

        // ---------------------------
        // Exercise 8: Name 'R' Star
        // ---------------------------

        var ex8_query = from s in students
                        where s.Name.StartsWith("R")
                        select s.Name;

        var ex8_method = students.Where(s => s.Name.StartsWith("R"))
                                 .Select(s => s.Name);

        Console.WriteLine("\nEx8: Name 'R' start:");
        Console.WriteLine(string.Join(", ", ex8_method));

        // ---------------------------
        // Exercise 9: Grouping — Marks ways Group
        // ---------------------------

        var ex9_query = from s in students
                        group s by s.Marks into g
                        select new { Mark = g.Key, Students = g };

        var ex9_method = students.GroupBy(s => s.Marks)
                                 .Select(g => new { Mark = g.Key, Students = g });

        Console.WriteLine("\nEx9: Marks ways Group:");
        foreach (var group in ex9_method)
        {
            Console.WriteLine($"Marks: {group.Mark}");
            foreach (var s in group.Students)
                Console.WriteLine($"   {s.Name}");
        }

        // ---------------------------
        // Exercise 10: Age > 20 and Marks ≥ 85
        // ---------------------------

        var ex10_query = from s in students
                         where s.Age > 20 && s.Marks >= 85
                         select s;

        var ex10_method = students.Where(s => s.Age > 20 && s.Marks >= 85);

        Console.WriteLine("\nEx10: Age > 20 And Marks ≥ 85:");
        foreach (var s in ex10_method)
            Console.WriteLine($"{s.Name} (Age: {s.Age}, Marks: {s.Marks})");
    }
}
