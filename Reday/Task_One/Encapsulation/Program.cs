using System;

class Person
{
	private string name = "";
	private int age;

	// Public property with simple getter/setter
	public string Name
	{
		get => name;
		set => name = value;
	}

	// Encapsulated Age with validation in the setter
	public int Age
	{
		get => age;
		set
		{
			if (value < 0)
				age = 0; // normalize invalid negative ages to 0
			else if (value > 120)
				age = 120; // clamp unrealistic ages
			else
				age = value;
		}
	}

	public void Display()
	{
		Console.WriteLine($"Name: {Name}, Age: {Age}");
	}
}

class Program
{
	static void Main(string[] args)
	{
		var p = new Person();
		p.Name = "Alice";
		p.Age = 30;
		p.Display();

		// Demonstrate encapsulation: invalid values are handled by the setter
		p.Age = -5;    // will be normalized to 0
		p.Display();

		p.Age = 200;   // will be clamped to 120
		p.Display();
	}
}


