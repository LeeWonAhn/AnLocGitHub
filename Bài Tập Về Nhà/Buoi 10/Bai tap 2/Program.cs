using System;
class Program
    {
        static void Main(string[] args)
        {
            // Create an array of geometric objects
            Shape[] shapes = new Shape[4];
            shapes[0] = new Circle(3.5);
            shapes[1] = new Square(5.8, "yellow", true);
            shapes[2] = new Rectangle(4.0, 5.0);
            shapes[3] = new Square(2.0);

            // Iterate through the array
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
                if (shape is IColorable colorable)
                {
                    colorable.HowToColor();
                }
            }
        }
    }

