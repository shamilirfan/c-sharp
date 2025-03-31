using System;

class TemperatureConverter
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Temperature Converter Started...");
        Console.WriteLine("Choose 1. Fahrenheit to Celsious");
        Console.WriteLine("Choose 2. Celsious to Fahrenheit");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter Fahrenheit Temperature: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsious = (fahrenheit - 32) / 1.8;
                Console.WriteLine($"Temperature in Celsious {celsious:F2}");
                break;
            case 2:
                Console.Write("Enter Celsious Temperature: ");
                double cel = Convert.ToDouble(Console.ReadLine());
                double fah = cel * 1.8 + 32;
                Console.WriteLine($"Temperature in Fahrenheit {fah:F2}");
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

    }
}