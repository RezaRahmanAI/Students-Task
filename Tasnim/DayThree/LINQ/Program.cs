// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
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

        //Question 1
        var ageOver20 = students.Where(s => s.Age > 20);

        Console.WriteLine("Students who are over 20 years old:");
        foreach (var i in ageOver20)
            Console.WriteLine(i.Name);

        // Question 2
        var marksOver80 = students.Where(s => s.Marks >= 80);

        Console.WriteLine("\nStudents who got marks over 80:");
        foreach (var i in marksOver80)
            Console.WriteLine(i.Name);

        // Question 3
        var studentName = students.OrderBy(s => s.Name);
        Console.WriteLine("\nStudents Sorted Name Alphabetical Order:");
        foreach (var i in studentName)
            Console.WriteLine(i.Name);

        // Question 4

        var maxMark = students.Max(s => s.Marks);
        Console.WriteLine($"\nThe maximum mark ({maxMark}):");

        // Question 5
        var avgMark = students.Average(s => s.Marks);
        Console.WriteLine($"\nThe average mark ({avgMark}):");

        // Question 6
        var minAge = students.Min(s => s.Age);
        var minAgeStudents = students.Where(s => s.Age == minAge);

        Console.WriteLine("\nYoungest students:");
        foreach (var s in minAgeStudents)
        {
            Console.WriteLine($"{s.Name}, {s.Age} years old");
        }

        //Question 7
        var projection = students.Select(s => new
        {
            id = s.Id,
            name = s.Name,

        });

        Console.WriteLine("Projection: Student Id and Name");
        foreach (var i in projection)
        {
            Console.WriteLine($"{i.id} {i.name}");
        }

        // Question 8
        var startWithR = students.Where(s => char.ToUpper(s.Name[0]) == 'R');

        Console.WriteLine("\nStudents whose name starts with R:");
        foreach (var i in startWithR)
            Console.WriteLine(i.Name);

        // Question 9
        var gradedGroups = students.GroupBy(s =>
        {
            if (s.Marks >= 90) return "A+";
            if (s.Marks >= 80) return "A";
            if (s.Marks >= 70) return "B";
            if (s.Marks >= 60) return "C";
            return "F";
        });

        foreach (var group in gradedGroups)
        {
            Console.WriteLine($"\nGrade {group.Key}:");
            foreach (var student in group)
            {
                Console.WriteLine($"{student.Name} ({student.Marks})");
            }
        }

        // Question 10
        var filteredStudents = students.Where(s => s.Age > 20 && s.Marks >= 85);

        Console.WriteLine("\nStudents with Age > 20 and Marks >= 85:");
        foreach (var student in filteredStudents)
        {
            Console.WriteLine($"{student.Name}");
        }






    }
}

