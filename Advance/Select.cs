using System;

class Select
{
    public static void Main(string[] args)
    {
        // use of select method
        int[] num1 = { 1, 2, 3, 4, 5 };

        var sqNumbers = num1.Select(a => a * a);

        foreach (var item in sqNumbers)
        {
            Console.Write($"{item} ");
        }

        string[] names = new string[5] { "rupa", "shiwly", "himal", "bob", "ripon" };

        var clNames = names.Select(a => Convert.ToString(a[0]).ToUpper() + a.Remove(0, 1));

        foreach (var item in clNames)
        {
            Console.Write($"\n{item}");
        }
    }
}
