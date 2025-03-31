//  Assignment - 5
using System;

class AreaCircle
{
    public static void Main(string[] args)
    {
        // Circle Area = 3.1416 * radious * radious
        double radious;

        Console.Write("Radious = ");
        radious = Convert.ToDouble(Console.ReadLine());

        double circleArea = 3.1416 * radious * radious;

        Console.WriteLine($"Circle Area = {circleArea.ToString("F2")}");
    }
}