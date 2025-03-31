using System;

class Assignment6
{
    public static void Main(string[] args)
    {
        // f = (1.8 * celsious) + 32
        double celsious, fahrenheit;

        Console.Write("celsious = ");
        celsious = Convert.ToDouble(Console.ReadLine());

        fahrenheit = (1.8 * celsious) + 32;

        Console.WriteLine($"fahrenheit = {fahrenheit:F2} degrees");
    }
}