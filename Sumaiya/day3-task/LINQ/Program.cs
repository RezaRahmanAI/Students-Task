// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace Linq
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    };
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

            // Exercise1
            var s = students.Where(s => s.Age > 20).ToList();

            foreach (var student in s)
            {
                Console.WriteLine($"{student.Name} {student.Age}");
            }


            var n = from x in students where x.Age > 20 select x;

            foreach (var student in n)
            {
                Console.WriteLine($"{student.Name} {student.Age}");
            }

            // Exercise2
            var m = students.Where(m => m.Marks >= 80).ToList();

            foreach (var student in m)
            {
                Console.WriteLine($"{student.Name}-{student.Marks}");
            }

            var mark = from y in students where y.Marks >= 80 select y;

            foreach (var student in mark)
            {
                Console.WriteLine($"{student.Name}-{student.Marks}");
            }

            // Exercise3
            var sort = students.OrderBy(sort => sort.Name).ToList();
            foreach (var student in sort)
            {
                Console.WriteLine($"{student.Name}");
            }


            var sorted = from z in students orderby z.Name select z;

            foreach (var student in sorted)
            {
                Console.WriteLine($"{student.Name}");
            }

            // Exercise4

            var h = students.Max(h => h.Marks);
            Console.WriteLine($"{h}");

            var high = (from a in students
                        orderby a.Marks descending
                        select a).First();

            Console.WriteLine($"{high.Marks}");



            // Exercise5
            var avgMarks = students.Average(s => s.Marks);
            Console.WriteLine($"Average Marks: {avgMarks}");


            var averageMarks = (from e in students
                                select e.Marks).Average();

            Console.WriteLine($"Average Marks: {averageMarks}");


            // Exercise6
            var min = students.Min(min => min.Age);
            var minStudent = students.Where(s => s.Age == min);


            foreach (var student in minStudent)
            {
                Console.WriteLine($"{student.Name} - {student.Age}");
            }

            var minAge = (from mAge in students
                          select mAge.Age).Min();

            var minStudents = from c in students
                              where c.Age == minAge
                              select c;


            foreach (var student in minStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Age}");
            }

            // Exercise7

            var p = students.Select(p => new { p.Id, p.Name });

            foreach (var student in p)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
            }

            var pro = from stu in students
                      select new { stu.Id, stu.Name };

            foreach (var student in pro)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
            }


            // Exercise8

            var start = students
                            .Where(start => start.Name.StartsWith("R"))
                            .Select(start => new { start.Name });

            foreach (var student in start)
            {
                Console.WriteLine($"Name star with R: {student.Name}");
            }


            var stuR = from w in students
                       where w.Name.StartsWith("R")
                       select new { w.Name };

            foreach (var student in stuR)
            {
                Console.WriteLine($"Name star with R: {student.Name}");
            }


            // Exercise9
            var groupedBy = students.GroupBy(g => g.Marks >= 85 ? "High" : g.Marks >= 70 ? "Medium" : "Low");

            foreach (var group in groupedBy)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"{student.Name} - Marks: {student.Marks}");
                }
            }


            var groupedByStu = from j in students
                               let category = j.Marks >= 85 ? "High" : j.Marks >= 70 ? "Medium" : "Low"
                               group j by category into g
                               orderby g.Key
                               select g;

            foreach (var group in groupedByStu)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"  {student.Name} - Marks: {student.Marks}");
                }
            }


            // Exercise10

            var stuT = students.Where(stuT => stuT.Age > 20 && stuT.Marks >= 85);

            foreach (var student in stuT)
            {
                Console.WriteLine($"{student.Name} - Age: {student.Age}, Marks: {student.Marks}");
            }


            var stuC = from k in students where k.Age > 20 && k.Marks >= 85 select k;

            foreach (var student in stuC)
            {
                Console.WriteLine($"{student.Name} - Age: {student.Age}, Marks: {student.Marks}");
            }

        }
        

    }

    
}
