public class Circle : Shape
{
    private double radius;

    public Circle(double radius, string color) : base(color)
    {
        this.radius = radius;
    }

    public double getRadius()
    {
        return radius;
    }

    public void setRadius(double radius)
    {
        this.radius = radius;
    }

    public double getArea()
    {
        return Math.PI * radius * radius;
    }

    public override string ToString()
    {
        return "Circle[Shape[color=" + getColor() + "], radius=" + radius + "]";
    }
}