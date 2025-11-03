using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Person class
            Person person = new Person("Reday", 25);

            // Display the person's information
            person.DisplayInfo();
        }
    }

    // Define a Person class
    class Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display person's information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

