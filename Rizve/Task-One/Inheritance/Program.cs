using System;

public class Employee
{
  public string Name { get; set; }

  public void Work()
  {
    Console.WriteLine($"{Name} is working.");
  }
}

public class Manager : Employee
{
  public void ManageTeam()
  {
    Console.WriteLine($"{Name} is managing the team.");
  }
}


class Program
{
  static void Main()
  {
    Manager manager = new Manager();
    manager.Name = "Alice";
    manager.Work();
    manager.ManageTeam();
  }
}