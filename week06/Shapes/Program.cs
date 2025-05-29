using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Rectangle("Red", 2, 4));
        shapes.Add(new Square("Green", 2));
        shapes.Add(new Circle("Blue", 2));

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Color: {s.GetColor()}, Area: {s.GetArea()}");
        }
    }
}