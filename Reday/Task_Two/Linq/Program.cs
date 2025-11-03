using System;
using System.Linq;

var evenNumbers = Enumerable.Range(1, 100).Where(n => n % 2 == 0);
Console.WriteLine("\nEven Numbers (1-100):");
Console.WriteLine(string.Join(", ", evenNumbers));