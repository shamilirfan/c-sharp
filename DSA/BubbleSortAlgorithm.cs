using System;

class BubbleSortAlgorithm
{
    public static void Main(string[] args)
    {
        int[] a = { 10, 5, 2, 8, 7, 1, 9, 3, 4, 6 };
        int b = 0;

        for (int i = 0; i < a.Length - 1; i += 1)
        {
            for (int j = 0; j < a.Length - i - 1; j += 1)
            {
                // Acsending sort
                if (a[j] > a[j + 1])
                {
                    b = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = b;
                }

                // Decsending sort
                // if (a[j] < a[j + 1])
                // {
                //     b = a[j];
                //     a[j] = a[j + 1];
                //     a[j + 1] = b;
                // }
            }
        }


        //
        foreach (int item in a)
        {
            Console.Write($"{item} ");
        }

    }
}