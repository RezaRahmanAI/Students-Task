// See https://aka.ms/new-console-template for more information

class Animal {
    public void Eat() {
        Console.WriteLine("This animal eats food.");
    }
}

class Dog : Animal {
    public void Bark() {
        Console.WriteLine("The dog barks.");
    }
}

class Program {
    static void Main() {
        Dog d = new Dog();
        d.Eat();  
        d.Bark();  
    }
}