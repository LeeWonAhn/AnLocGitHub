﻿public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the width:");
        double width = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height:");
        double height = Double.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(height, width);

        Console.WriteLine("Your Rectangle \n" + rectangle.Display());
        Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
        Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());
    }
}