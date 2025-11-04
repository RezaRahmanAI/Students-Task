using System;

class Person
{
    public string FirstName;
    public string LastName;
    public int Age;

    public void DisplayFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.FirstName = "John";
        person.LastName = "Doe";
        person.Age = 25;
        person.DisplayFullName();
    }
}
