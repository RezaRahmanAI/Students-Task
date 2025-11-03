using System;
using System.Globalization;

public class Car
{
  public string Brand { get; set; }
  public string Model { get; set; }

  public void DisplayInfo()
  {
    Console.WriteLine($"Car Brand: {Brand}, Model: {Model}");
  }
}


class Program
{
  static void Main(string[] agrs)
  {
    Car myCar = new Car();
    myCar.Brand = "Toyota";
    myCar.Model = "Corolla";
    myCar.DisplayInfo();
  }
}