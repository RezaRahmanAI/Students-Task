using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var students = new List<Student>
        {
            new Student { Id = 1, Name = "Rizve", Age = 22, Marks = 85 },
            new Student { Id = 2, Name = "Rahim", Age = 20, Marks = 72 },
            new Student { Id = 3, Name = "Karim", Age = 23, Marks = 90 },
            new Student { Id = 4, Name = "Sonia", Age = 19, Marks = 65 },
            new Student { Id = 5, Name = "Lima", Age = 21, Marks = 95 }
        };

        // 🔹 Task 1: Find the students over 20 (Age > 20)

        // ✅ Query Syntax
        var query1 = from s in students
                     where s.Age > 20
                     select s;

        Console.WriteLine("Students with Age > 20 (Query Syntax):");
        foreach (var s in query1)
        {
            Console.WriteLine($"{s.Name} - Age: {s.Age}");
        }

        // ✅ Method Syntax
        var method1 = students.Where(s => s.Age > 20);

        Console.WriteLine("\nStudents with Age > 20 (Method Syntax):");
        foreach (var s in method1)
        {
            Console.WriteLine($"{s.Name} - Age: {s.Age}");
        }
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}