class Vehicle
{
    public string brand = "BMW";
    public void honk()
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle
{
    public string modelName = "I7 Series";
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