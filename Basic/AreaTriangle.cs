using System;

// Assignment 4

class AreaTriangle
{
    public static void Main(string[] args)
    {
        // Triangle Area = 0.5 * base * height
        double baseLength, height;

        Console.Write("Base = ");
        baseLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Height = ");
        height = Convert.ToDouble(Console.ReadLine());

        double TriangleArea = 0.5 * baseLength * height;

        Console.WriteLine($"Triangle Area = {TriangleArea}");
    }
}