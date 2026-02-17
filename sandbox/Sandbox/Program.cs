using System;
using System.Collections.Generic;

public class Shape
{
    public string Name { get; set; }

    public virtual void Draw()
    {
        Console.WriteLine($"Drawing a generic shape called: {Name}");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a circle called: {Name}");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drwaing a rectangle called: {Name}"); 
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<Shape> myShapes = new List<Shape>
        {
            new Circle { Name = "Circle A" },
            new Rectangle { Name = "Rectangle B" },
            new Shape { Name = "Mysterious Shape" }
        };

        foreach (var shape in myShapes)
        {
            shape.Draw();
        }
    }
}