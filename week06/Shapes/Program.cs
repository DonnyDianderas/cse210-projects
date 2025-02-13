using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square ("Blue",5);
        shapes.Add(square);

        Circle circle = new Circle ("Red", 2);
        shapes.Add(circle);

        Rectangle rectangle = new Rectangle ("Black", 3, 5);
        shapes.Add(rectangle);

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
        
        
        
        /*Square square = new Square("Blue",5);
        Circle circle = new Circle("Red", 2);
        Rectangle rectangle = new Rectangle ("Black", 3, 5);


        string color = square.GetColor();
        double area = square.GetArea();
        string color1 = circle.GetColor();
        double area1 = circle.GetArea();
        string color2 = rectangle.GetColor();
        double area2 = rectangle.GetArea();

        Console.WriteLine($"The {color} shape has an area of {area}.");
        Console.WriteLine($"The {color1} shape has an area of {area1}.");
        Console.WriteLine($"The {color2} shape has an area of {area2}.");*/
    }
}