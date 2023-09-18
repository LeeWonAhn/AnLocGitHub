using System;

namespace Shape
{
  class Program
  {
    static void Main(string[] args)
    {
      // Shape Test
      Shape shape = new Shape();
      Console.WriteLine(shape);

      shape = new Shape("red", false);
      Console.WriteLine(shape);

      // Circle Test
      Circle circle = new Circle();
      Console.WriteLine(circle);

      circle = new Circle(3.5);
      Console.WriteLine(circle);

      circle = new Circle(3.5, "indigo", false);
      Console.WriteLine(circle);

      // Square Test
      Square square = new Square();
      Console.WriteLine(square);

      square = new Square(2.3);
      Console.WriteLine(square);

      square = new Square(5.8, "yellow", true);
      Console.WriteLine(square);

        List<Shape> shapes = new List<Shape>
        {
            new Circle(3.0),
            new Rectangle(4.0, 5.0),
            new Square(2.0)
        };
        foreach (var shape in shapes)
        {
            Console.WriteLine("Thông tin trước khi tăng kích thước: " + shape);
            double percent = new Random().Next(1, 101);
            shape.Resize(percent);
            Console.WriteLine("Thông tin sau khi tăng kích thước: " + shape);
            Console.WriteLine();
        }
  }
  }
  }