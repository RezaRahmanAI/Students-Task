// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

List<int> numbers = new List<int>();



for (int i = 1; i <= 100; i++)
{
    numbers.Add(i);
}

var result = numbers.Where(x => x % 2 == 0).Select(x => x);

// Console.WriteLine(result);

foreach(int x in result){
    Console.Write($"{x} ");
}