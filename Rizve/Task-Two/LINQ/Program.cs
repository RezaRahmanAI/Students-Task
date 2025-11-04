using System;
using System.Security.Cryptography.X509Certificates;


var students = new List<Student>
{
    new Student { Id = 1, Name = "Rizve", Age = 22, Marks = 85 },
    new Student { Id = 2, Name = "Rahim", Age = 20, Marks = 72 },
    new Student { Id = 3, Name = "Karim", Age = 23, Marks = 90 },
    new Student { Id = 4, Name = "Sonia", Age = 19, Marks = 65 },
    new Student { Id = 5, Name = "Lima", Age = 21, Marks = 95 }
};


// Method Syntax
var olderStudents = students.Where(s => s.Age > 20).ToList();

foreach (var stu in olderStudents)
{
  Console.WriteLine($"Id: {stu.Id}, Name: {stu.Name}, Age: {stu.Age}, Marks: {stu.Marks}");
}

var sortedStudents = students.OrderBy(s => s.Name).ToList();
Console.WriteLine("---- Sorted Students by Name ----");
foreach (var student in sortedStudents)
{
  Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Marks: {student.Marks}");
}

var topStudent = students.Max(s => s.Marks);
Console.WriteLine("---- Top Student Marks ----");
Console.WriteLine($"Highest Marks: {topStudent}");


var topTwo = students.OrderByDescending(s => s.Marks).Take(2).ToList();


Console.WriteLine("---- Query Syntax ----");

// Query Syntax
var highScorers = from s in students where s.Id == 1 select s;

foreach (var st in highScorers)
{
  Console.WriteLine($"Id: {st.Id}, Name: {st.Name}, Age: {st.Age}, Marks: {st.Marks}");
}

var topTwoQuery = (from s in students orderby s.Marks descending select s).Take(2);



public class Student
{
  public int Id { get; set; }
  public required string Name { get; set; }
  public int Age { get; set; }
  public int Marks { get; set; }
}



