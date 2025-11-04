using System;

public abstract class Vehicle
{
    public abstract void StartEngine(); //dfforoioptk
}

public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started with a key.");
    }
}

public class Motorcycle : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Motorcycle engine started with a button.");
    }
}

public class Program
{
    public static void Main()
    {
        Vehicle car = new Car();
        Vehicle motorcycle = new Motorcycle();

        car.StartEngine();
        motorcycle.StartEngine();
    }
}
