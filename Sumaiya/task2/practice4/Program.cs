// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public record EmployeeRecord(string Name, string Department, double Salary);

class Program
{
    static void Main()
    {
        List<EmployeeRecord> employees = new List<EmployeeRecord>
        {
            new EmployeeRecord("Nishat", "IT", 50000),
            new EmployeeRecord("Sumaiya", "Designer", 55000)
        };

        foreach (var emp in employees)
        {
            Console.WriteLine(emp); 
        }
    }
}
