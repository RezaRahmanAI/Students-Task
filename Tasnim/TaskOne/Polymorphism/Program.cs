// See https://aka.ms/new-console-template for more information

class Geeks
{
    public void greet()
    {
        Console.WriteLine("Hello");
    }

    public void greet(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    static void Main(string[] args)
    {
        Geeks p1 = new Geeks();

        p1.greet();

        p1.greet("Geeks");

    }
}