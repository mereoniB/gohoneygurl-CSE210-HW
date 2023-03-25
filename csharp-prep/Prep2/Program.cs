using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congrats, you passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, better luck next semester!");
        }
    }
}

using System;

// Define an abstract class for a shape
public abstract class Shape
{
    public abstract double Area();
    public abstract double Perimeter();
}

// Define a concrete class for a rectangle that inherits from Shape
public class Rectangle : Shape
{
    private double length;
    private double width;
    
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }
    
    public override double Area()
    {
        return length * width;
    }
    
    public override double Perimeter()
    {
        return 2 * (length + width);
    }
}

// Define a concrete class for a circle that inherits from Shape
public class Circle : Shape
{
    private double radius;
    
    public Circle(double radius)
    {
        this.radius = radius;
    }
    
    public override double Area()
    {
        return 3.14 * radius * radius;
    }
    
    public override double Perimeter()
    {
        return 2 * 3.14 * radius;
    }
}

// Create a rectangle and a circle, and print their area and perimeter
Rectangle rectangle = new Rectangle(4, 5);
Circle circle = new Circle(3);

Console.WriteLine("Rectangle area: " + rectangle.Area());
Console.WriteLine("Rectangle perimeter: " + rectangle.Perimeter());
Console.WriteLine("Circle area: " + circle.Area());
Console.WriteLine("Circle perimeter: " + circle.Perimeter());
