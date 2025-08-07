using System;

class OrderBy
{
    public static void Main(string[] args)
    {
        int[] num1 = new int[5] { 5, 4, 3, 2, 1 };

        var a = num1.OrderBy(b => b); // use of OrderBy

        foreach (var item in a)
        {
            Console.Write($"{item} ");
        }
    }
}
