using System;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof");
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        animal.Speak();

        Dog dog = new Dog();
        dog.Speak();
    }
}
