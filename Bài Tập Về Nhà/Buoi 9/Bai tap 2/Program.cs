public class Program
{
    public static void Main(string[] args)
    {
        Point2D point2D = new Point2D(1.0f, 2.0f);
        Point3D point3D = new Point3D(3.0f, 4.0f, 5.0f);

        Console.WriteLine("Point2D: " + point2D.ToString());
        Console.WriteLine("Point3D: " + point3D.ToString());
    }
}