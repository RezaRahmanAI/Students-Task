// See https://aka.ms/new-console-template for more information
class Color
{
    string color;

    public Color(string color = "red")
    {
        this.color = color;
    }


    public void displalyColor()
    {
        Console.WriteLine($"Color is {this.color}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Color c1 = new Color();
        c1.displalyColor();

        Color c2 = new Color("Blue");
        c2.displalyColor();
    }
}