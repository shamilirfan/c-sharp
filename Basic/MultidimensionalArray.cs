using System;

class MultidimensionalArray
{
    public static void Main(string[] args)
    {
        // 2d array
        int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };

        // row = 0, 1; col = 0, 1, 2;
        Console.WriteLine($"{numbers[0, 1]}");
        Console.WriteLine($"{numbers[1, 1]}");


        //
        for (int row = 0; row < 2; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.WriteLine($"{numbers[row, col]} ");
            }
            Console.WriteLine();
        }


    }
}