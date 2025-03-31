using System;

class TemperatureCon
{
    public static void Main(string[] args)
    {
        // c / 5 = f - 32 / 9
        // c = (fahrenheit - 32) / 1.8
        double fahrenheit, celsious;

        Console.Write("fahrenheit = ");
        fahrenheit = Convert.ToDouble(Console.ReadLine());

        celsious = (fahrenheit - 32) / 1.8;

        Console.WriteLine($"celsious = {celsious:F2} degrees");

    }
}