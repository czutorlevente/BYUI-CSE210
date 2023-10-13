using System;

class Program
{
    static void Main(string[] args)
    {
        Circle _c1 = new Circle(3, "purple");
        Square _s1 = new Square(2, "blue");
        Rectangle _r1 = new Rectangle(2, 3, "red");

        List<Shape> list_1 = new List<Shape>{
            _c1,
            _r1,
            _s1
        };

        foreach (Shape shape in list_1)
        {
            Console.WriteLine($"Hello: {shape.GetArea()} {shape.GetColor()}");
        }

    }
}