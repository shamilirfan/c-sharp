using System;

class ShallowCopyVsDeepCopy
{
    public static void PrintArray(int[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.Write($"{number} ");

        }
        Console.WriteLine();
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        // Shallow copy
        int[] originalArray = { 1, 2, 3, 4, 5 };
        int[] shallowCopy = originalArray;

        Console.Write($"originalArray before modification: ");
        PrintArray(originalArray);

        Console.Write($"shallowCopy before modification: ");
        PrintArray(shallowCopy);

        // change value from Shallow copy
        shallowCopy[0] = 10;

        Console.Write($"originalArray after modification: ");
        PrintArray(originalArray);

        Console.Write($"shallowCopy after modification: ");
        PrintArray(shallowCopy);





        // Deep Copy
        int[] originalArray2 = { 1, 2, 3, 4, 5 };
        int[] deepCopy = new int[originalArray2.Length];
        Array.Copy(originalArray2, deepCopy, originalArray2.Length);

        Console.Write($"originalArray2 before modification: ");
        PrintArray(originalArray2);

        Console.Write($"deepCopy before modification: ");
        PrintArray(deepCopy);

        // change value from Deep copy
        deepCopy[0] = 10;

        Console.Write($"originalArray2 after modification: ");
        PrintArray(originalArray2);

        Console.Write($"deepCopy after modification: ");
        PrintArray(deepCopy);

    }
}