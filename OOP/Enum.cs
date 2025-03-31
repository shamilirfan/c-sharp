using System;

// 28
enum Months
{
    January, // 0
    February, // 1
    March, // 2
    April, // 3
    May, // 4
    June, // 5
    July // 6
}

class Enum
{
    public static void Main(string[] args)
    {
        Months a = Months.February;
        Console.WriteLine($"{a}");

        int b = (int)Months.February;
        Console.WriteLine($"{b}");

        // use of enums with switch case
        Months c = Months.February;
        switch (c)
        {
            case Months.January:
                Console.WriteLine($"{Months.January}");
                break;
            case Months.February:
                Console.WriteLine($"{Months.February} is the month of mother tongue.");
                break;
            case Months.March:
                Console.WriteLine($"{Months.March} is the month of victory.");
                break;
        }
    }
}
