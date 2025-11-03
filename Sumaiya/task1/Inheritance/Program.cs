// See https://aka.ms/new-console-template for more information
class Vehicle

{
    public string brand = "Ford";
    public void honk()
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle
{
    public string modelName = "Mustang";
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();

        myCar.honk();

        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
}