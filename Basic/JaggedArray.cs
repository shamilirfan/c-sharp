using System;

class JaggedArray
{
    public static void Main(string[] args)
    {
        // Jagged Array means Array of Array
        // array and array row declare
        int[][] numbers = new int[4][]{
        new int[] { 1, 2 },
        new int[] { 3, 4, 5 },
        new int[] { 6 },
        new int[] { 7, 8, 9, 10 }
        };

        Console.WriteLine($"{numbers[0][0]}");
        Console.WriteLine($"{numbers[3][2]}");


        //
        foreach (var row in numbers)
        {
            foreach (var col in row)
            {
                Console.Write($"{col} ");
            }
            Console.WriteLine();
        }


    }
}