using System;
using System.Collections.Generic;

public class Shape
{
    public virtual double Area()
    {
        return 0;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area()
    {
        return Width * Height;
    }
}

public class Program
{
    public static void Main()
    {
        List<Shape> shapes = new List<Shape>()
        {
            new Circle(5),
            new Rectangle(4, 6)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area: {shape.Area()}");
        }
    }
}
