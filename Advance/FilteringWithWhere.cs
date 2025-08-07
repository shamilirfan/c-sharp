using System;

class FilteringWithWhere
{
    public static void Main(string[] args)
    {
        List<int> num1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // number filtering
        var evenNumbers = num1.Where(a => a % 2 == 0);

        // even numbers counting
        Console.WriteLine($"count of even numbers = {evenNumbers.Count()}");

        // even numbers print
        foreach (var item in evenNumbers)
        {
            Console.Write($"{item} ");
        }

        // use of Any method
        List<int> num2 = new List<int> { 1, 3, 5, 7, 9 };

        var a = num2.Where(h => h % 2 == 0);

        if (a.Any()) // use of Any
        {
            foreach (var item in a)
            {
                Console.Write($"\n{item} ");
            }
        }
        else
        {
            Console.WriteLine($"\nEven number not found!");
        }

        // string filtering
        List<string> fruits = new List<string> { "Grap", "Banana", "Apple", "Orange", "Mango" };

        // filtering
        var b = fruits.Where(t => t.Length > 5);

        foreach (var item in b)
        {
            Console.WriteLine($"{item}");
        }
    }
}
