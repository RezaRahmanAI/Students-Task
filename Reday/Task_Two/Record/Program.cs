using System;

namespace Record
{
       public record EmployeeRecord(string Name, string Department, double Salary);

       class Program
       {
              static void Main(string[] args)
              {
                     var emp = new EmployeeRecord("Rasel", "IT", 50000);
                     Console.WriteLine($"\nEmployee: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary}");
              }
       }
}