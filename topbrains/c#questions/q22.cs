using System;
using System.Linq;

public interface IArea
{
    double GetArea();
}

public abstract class Shape : IArea
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    private double r;
    public Circle(double r) { this.r = r; }
    public override double GetArea() => Math.PI * r * r;
}

public class Rectangle : Shape
{
    private double w, h;
    public Rectangle(double w, double h) { this.w = w; this.h = h; }
    public override double GetArea() => w * h;
}

public class Triangle : Shape
{
    private double b, h;
    public Triangle(double b, double h) { this.b = b; this.h = h; }
    public override double GetArea() => 0.5 * b * h;
}

public class Program
{
    public static double TotalArea(string[] shapes)
    {
        var total = shapes
            .Select(s =>
            {
                var p = s.Split(' ');
                return p[0] switch
                {
                    "C" => (Shape)new Circle(double.Parse(p[1])),
                    "R" => new Rectangle(double.Parse(p[1]), double.Parse(p[2])),
                    "T" => new Triangle(double.Parse(p[1]), double.Parse(p[2])),
                    _ => null
                };
            })
            .Where(x => x != null)
            .Sum(x => x.GetArea());

        return Math.Round(total, 2, MidpointRounding.AwayFromZero);
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] shapes = new string[n];
        for (int i = 0; i < n; i++)
            shapes[i] = Console.ReadLine();

        Console.WriteLine(TotalArea(shapes));
    }
}