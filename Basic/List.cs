using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class List
{
    public static void Main(string[] args)
    {
        List<string> flowers = new List<string>();

        flowers.Add("Jasmine");
        flowers.Add("Marigold");
        flowers.Add("Popy");
        flowers.Add("Daffodil");
        flowers.Add("Popy");

        //// Built in method
        // flowers.Remove("Jasmine");
        // flowers.Insert(1, "Rose");
        // Console.WriteLine($"{flowers.Count}");
        // Console.WriteLine($"{flowers.IndexOf("Daffodil")}");
        // Console.WriteLine($"{flowers.LastIndexOf("Popy")}");
        // Console.WriteLine($"{flowers.Contains("Popy")}");

        foreach (string flower in flowers)
        {
            Console.WriteLine($"{flower}");
        }
        Console.WriteLine();

        string[] flowersArray = flowers.ToArray();

        foreach (string item in flowersArray)
        {
            Console.WriteLine($"{item}");
        }

    }
}