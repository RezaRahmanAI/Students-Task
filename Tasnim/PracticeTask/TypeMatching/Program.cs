using System;

Console.Write("Enter what you want to input: ");
string? userInput = Console.ReadLine();

if (userInput == null)
{
    Console.WriteLine("No input provided..");
    return;
}

object input;

if (int.TryParse(userInput, out int i))
    input = i;
else if (double.TryParse(userInput, out double d))
    input = d;
else
    input = userInput;

switch (input)
{
    case int integer:
        Console.WriteLine($"You entered an integer: {integer}");
        break;
    case double d:
        Console.WriteLine($"You entered a double: {d}");
        break;
    case string s:
        Console.WriteLine($"You entered a string: \"{s}\"");
        break;
}
