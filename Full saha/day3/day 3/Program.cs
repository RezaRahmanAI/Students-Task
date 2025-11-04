// See https://aka.ms/new-console-template for more information


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

        //Exercise 1
        var ageOver20 = students.Where(s => s.Age > 20);

        Console.WriteLine("Students who are over 20 years old:");
        foreach (var i in ageOver20)
            Console.WriteLine(i.Name);

        var marksOver80 = students.Where(s => s.Marks >= 80).Select(s => s.Name);
        Console.WriteLine("Exercise 2: Students with Marks ≥ 80:");
        foreach (var name in marksOver80)
            Console.WriteLine(name);
        Console.WriteLine();

        // Exercise 3: 
        var sortedNames = students.OrderBy(s => s.Name).Select(s => s.Name);
        Console.WriteLine("Exercise 3: Students sorted alphabetically:");
        foreach (var name in sortedNames)
            Console.WriteLine(name);
        Console.WriteLine();

        // Exercise 4: 
        var maxMark = students.Max(s => s.Marks);
        Console.WriteLine($"Exercise 4: Highest Mark = {maxMark}");
        Console.WriteLine();

        // Exercise 5:
        var avgMark = students.Average(s => s.Marks);
        Console.WriteLine($"Exercise 5: Average Mark = {avgMark:F2}");
        Console.WriteLine();

        // Exercise 6: 
        var youngest = students.OrderBy(s => s.Age).First();
        Console.WriteLine($"Exercise 6: Youngest Student = {youngest.Name}, Age = {youngest.Age}");
        Console.WriteLine();

        // Exercise 7: 
        var idNameList = students.Select(s => new { s.Id, s.Name });
        Console.WriteLine("Exercise 7: ID and Name projection:");
        foreach (var s in idNameList)
            Console.WriteLine($"ID: {s.Id}, Name: {s.Name}");
        Console.WriteLine();

        // Exercise 8: 
        var startsWithR = students.Where(s => s.Name.StartsWith("R"));
        Console.WriteLine("Exercise 8: Students whose name starts with 'R':");
        foreach (var s in startsWithR)
            Console.WriteLine(s.Name);
        Console.WriteLine();

        // Exercise 9:
        var groupByMarks = students.GroupBy(s => s.Marks);
        Console.WriteLine("Exercise 9: Grouping by Marks:");
        foreach (var group in groupByMarks)
        {
            Console.WriteLine($"Marks: {group.Key}, Students: {string.Join(", ", group.Select(s => s.Name))}");
        }
        Console.WriteLine();

        // Exercise 10: 
        var condition = students.Where(s => s.Age > 20 && s.Marks >= 85);
        Console.WriteLine("Exercise 10: Students with Age > 20 and Marks ≥ 85:");
        foreach (var s in condition)
            Console.WriteLine(s.Name);
            var top2Students = students
    .OrderByDescending(s => s.Marks) 
    .Take(2);                        

Console.WriteLine("Top 2 Students:");
foreach (var s in top2Students)
{
    Console.WriteLine($"Name: {s.Name}, Marks: {s.Marks}");

    }


}













class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}
