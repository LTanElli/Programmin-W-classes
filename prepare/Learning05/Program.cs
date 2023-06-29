using System;

class Program
{
    static void Main(string[] args)
    {
        var square = new Square(5, "blue");
        var rectangle = new Rectangle(5, 6, "red");
        var circle = new Circle(5, "purple");

        var shapees = new List<Shape> { square, rectangle, circle};

        foreach (var shapee in shapees) {
            Console.WriteLine(shapee.GetColor());
            Console.WriteLine(shapee.GetArea());
            Console.WriteLine("--------");
        }   
    }
}

public class Shape
{
    protected string _color;

    public Shape(string color) {
        _color = color;
    }

    virtual public double GetArea() {
        return 0;
    }

    public string SetColor(string _color) {
        Console.Write("Choose a color: ");
        _color = Console.ReadLine();
        return _color;
    }

    public string GetColor() {
        return _color;
    }
}

public class Square : Shape
{
    double _side;

    public Square(double side, string color) : base(color) {
        _side = side;
    }

    public override double GetArea() {
        return Math.Pow(_side, 2);
    }
}

public class Rectangle : Shape 
{
    double _length;
    double _width;

    public Rectangle(double length, double width, string color) : base(color) {
        _length = length;
        _width = width;
    }

    public override double GetArea() {
        return _length * _width;
    }
}

public class Circle : Shape 
{
    double _radius;

    public Circle(double radius, string color) : base(color) {
        _radius = radius;
    }

    public override double GetArea() {
        return Math.PI * (Math.Pow(_radius, 2));
    }
}