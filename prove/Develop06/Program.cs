using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(5);

        square.SetColor("Red");

        Console.WriteLine($"Square Area: {square.GetArea()}");
        Console.WriteLine($"Square Color: {square.GetColor()}");

        Rectangle rectangle = new Rectangle(5, 10);

        rectangle.SetColor("Blue");

        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}");

        Circle circle = new Circle(5);

        circle.SetColor("Green");

        Console.WriteLine($"Circle Area: {circle.GetArea()}");
        Console.WriteLine($"Circle Color: {circle.GetColor()}");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"Shape Area: {shape.GetArea()}");
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
        }
    }
}