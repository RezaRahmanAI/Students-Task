using System;
using System.Collections.Generic;
using System.Linq;

namespace GPA
{
    class Student
    {
    public string Name { get; set; } = string.Empty;
        public int Roll { get; set; }
        public double Marks { get; set; }

        // Method to return GPA
        public double GetGPA()
        {
            if (Marks >= 80) return 4.0;
            else if (Marks >= 70) return 3.5;
            else if (Marks >= 60) return 3.0;
            else if (Marks >= 50) return 2.5;
            else return 0.0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Demo data
            var students = new List<Student>
            {
                new Student { Name = "Reday", Roll = 1, Marks = 92 },
                new Student { Name = "Akash",   Roll = 2, Marks = 75 },
                new Student { Name = "Kajol",  Roll = 3, Marks = 61 },
                new Student { Name = "Partho",   Roll = 4, Marks = 48 }
            };

            Console.WriteLine("Name\tRoll\tMarks\tGPA");
            foreach (var s in students)
            {
                Console.WriteLine($"{s.Name}\t{s.Roll}\t{s.Marks}\t{s.GetGPA():0.00}");
            }

            var avgGpa = students.Any() ? students.Average(s => s.GetGPA()) : 0.0;
            Console.WriteLine();
            Console.WriteLine($"Average GPA: {avgGpa:0.00}");
        }
    }
}