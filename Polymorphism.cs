public abstract class Shape
{
    // Abstract method that must be implemented by derived classes
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Implement the abstract method to calculate the area of a circle
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    // Implement the abstract method to calculate the area of a rectangle
    public override double CalculateArea()
    {
        return length * width;
    }
}
