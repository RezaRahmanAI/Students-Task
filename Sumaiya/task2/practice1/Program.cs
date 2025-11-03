
using System;

class Student
{
    public string Name =" ";
    public int Roll;
    public double Marks;

    public double GPA()
    {
        if (Marks >= 80) return 5.0;
        else if (Marks >= 70) return 4.0;
        else if (Marks >= 60) return 3.5;
        else if (Marks >= 50) return 3.0;
        else if (Marks >= 40) return 2.0;
        else return 0.0;  
    }
}

class Program
{
    static void Main(string[] args)
    {
    
        Student s = new Student();
        s.Name = "Nishat";
        s.Roll = 101;
        s.Marks = 70;

        Console.WriteLine($"Name: {s.Name}, Roll: {s.Roll}, Marks: {s.Marks}, GPA: {s.GPA()}");
    }
}
