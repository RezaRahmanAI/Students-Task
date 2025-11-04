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

       
        var ageAbove20_QS = from s in students
                            where s.Age > 20
                            select s;

        var ageAbove20_MS = students.Where(s => s.Age > 20);

        foreach (var s in ageAbove20_MS) Console.WriteLine($"Exercise 1: {s.Name}");

     
        var marksAbove80_QS = from s in students
                              where s.Marks >= 80
                              select s.Name;
        var marksAbove80_MS = students.Where(s => s.Marks >= 80).Select(s => s.Name);

        foreach (var name in marksAbove80_MS) Console.WriteLine($"Exercise 2: {name}");

  
        var sortedNames_QS = from s in students
                             orderby s.Name
                             select s.Name;
        var sortedNames_MS = students.Select(s => s.Name).OrderBy(n => n);

        foreach (var name in sortedNames_MS) Console.WriteLine($"Exercise 3: {name}");

        var maxMark = students.Max(s => s.Marks);
        Console.WriteLine($"Exercise 4: Maximum Mark = {maxMark}");

      
        var avgMark = students.Average(s => s.Marks); // Method Syntax
        Console.WriteLine($"Exercise 5: Average Mark = {avgMark}");

        var youngest_QS = (from s in students
                           orderby s.Age
                           select s).First();
        var youngest_MS = students.OrderBy(s => s.Age).First();

        Console.WriteLine($"Exercise 6: Youngest = {youngest_MS.Name}, Age = {youngest_MS.Age}");

        var idAndName_QS = from s in students
                           select new { s.Id, s.Name };
        var idAndName_MS = students.Select(s => new { s.Id, s.Name });

        foreach (var s in idAndName_MS) Console.WriteLine($"Exercise 7: Id={s.Id}, Name={s.Name}");

     
        var nameStartsWithR_QS = from s in students
                                 where s.Name.StartsWith("R")
                                 select s.Name;
        var nameStartsWithR_MS = students.Where(s => s.Name.StartsWith("R"))
                                         .Select(s => s.Name);

        foreach (var name in nameStartsWithR_MS) Console.WriteLine($"Exercise 8: {name}");

        var groupByMarks_QS = from s in students
                              group s by s.Marks;
        var groupByMarks_MS = students.GroupBy(s => s.Marks);

        foreach (var group in groupByMarks_MS)
        {
            Console.WriteLine($"Exercise 9: Marks={group.Key}");
            foreach (var s in group) Console.WriteLine($"  {s.Name}");
        }

       
        var filtered_QS = from s in students
                          where s.Age > 20 && s.Marks >= 85
                          select s;
        var filtered_MS = students.Where(s => s.Age > 20 && s.Marks >= 85);

        foreach (var s in filtered_MS) Console.WriteLine($"Exercise 10: {s.Name}");
    }
}

public class Student
{
    public int Id { get; set; }
    public required string Name { get; set; } 
    public int Age { get; set; }
    public int Marks { get; set; }
}
