using System;

class ConvertAll
{
    public static void Main(string[] args)
    {
        string[] a = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        int[] b = Array.ConvertAll(a, int.Parse);

        foreach (int item in b)
        {
            Console.Write($"{item} ");
        }

    }
}