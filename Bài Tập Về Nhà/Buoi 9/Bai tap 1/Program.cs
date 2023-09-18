public class Program
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(5.0, "Red");
        Cylinder cylinder = new Cylinder(3.0, "Blue", 7.0);

        Console.WriteLine(circle.ToString());
        Console.WriteLine("Circle Area: " + circle.getArea());

        Console.WriteLine(cylinder.ToString());
        Console.WriteLine("Cylinder Volume: " + cylinder.getVolume());
    }
}