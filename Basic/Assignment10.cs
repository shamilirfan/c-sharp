using System;

class Assignment10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a day of week: ");
        string a = Console.ReadLine();

        switch (a.ToLower())
        {
            case "monday":
            case "tuesday":
            case "wednesday":
            case "thursday":
            case "friday":
                Console.WriteLine($"{a} is weekday.");
                break;
            case "saturday":
            case "sunday":
                Console.WriteLine($"{a} is weekend.");
                break;
            default:
                Console.WriteLine($"{a} is Not valid!");
                break;
        }

    }
}