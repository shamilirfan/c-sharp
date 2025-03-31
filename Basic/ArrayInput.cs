using System;

class ArrayInput
{
    public static void Main(string[] args)
    {
        Console.Write($"How many elements you want! ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }



    }
}