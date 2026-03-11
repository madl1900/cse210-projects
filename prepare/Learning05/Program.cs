using System;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("blue", 12);

        Rectangle myRectangle = new Rectangle("red", 10, 3);

        Circle myCircle = new Circle("yellow", 5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(mySquare);
        shapes.Add(myRectangle);
        shapes.Add(myCircle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} Area: {shape.GetArea()}");
        }
    }
}