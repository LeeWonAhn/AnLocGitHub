public class Cylinder : Circle
{
    private double height;

    public Cylinder(double radius, string color, double height) : base(radius, color)
    {
        this.height = height;
    }

    public double getHeight()
    {
        return height;
    }

    public void setHeight(double height)
    {
        this.height = height;
    }

    public double getVolume()
    {
        return getArea() * height;
    }

    public override string ToString()
    {
        return "Cylinder[Circle[Shape[color=" + getColor() + "], radius=" + getRadius() + "], height=" + height + "]";
    }
}