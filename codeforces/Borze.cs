using System;

class Borze
{
    public static void Main(string[] args)
    {
        string? input = Console.ReadLine();
        string[] array = new string[input.Length];

        for (int a = 0; a < input.Length; a += 1)
        {
            array[a] = Convert.ToString(input[a]);
        }

        for (int b = 0; b < array.Length; b += 1)
        {
            if (array[b] == ".")
            {
                Console.Write(0);
            }
            else if (array[b] == "-" && array[b + 1] == ".")
            {
                Console.Write(1);
                b++;
            }
            else if (array[b] == "-" && array[b + 1] == "-")
            {
                Console.Write(2);
                b++;
            }
        }

    }
}