using System;

class BeautifulMatrix
{
    public static void Main(string[] args)
    {
        // input-1
        string[] input1 = Console.ReadLine().Split(' ');
        string[] inputArray1 = new string[input1.Length];
        int x = 0;
        int y = 0;

        for (int i = 0; i < input1.Length; i++)
        {
            inputArray1[i] = input1[i];
            if (input1[i] == "1")
            {
                x = 2;
            }
        }

        if (inputArray1[0] == "1" || inputArray1[4] == "1")
        {
            y = 2;
        }
        else if (inputArray1[2] == "1")
        {
            y = 0;
        }
        else if (inputArray1[1] == "1" || inputArray1[3] == "1")
        {
            y = 1;
        }

        // input-2
        string[] input2 = Console.ReadLine().Split(' ');
        string[] inputArray2 = new string[input2.Length];

        for (int i = 0; i < input1.Length; i++)
        {
            inputArray2[i] = input2[i];
            if (input2[i] == "1")
            {
                x = 1;
            }
        }

        if (inputArray2[0] == "1" || inputArray2[4] == "1")
        {
            y = 2;
        }
        else if (inputArray2[2] == "1")
        {
            y = 0;
        }
        else if (inputArray2[1] == "1" || inputArray2[3] == "1")
        {
            y = 1;
        }

        // input-3
        string[] input3 = Console.ReadLine().Split(' ');
        string[] inputArray3 = new string[input3.Length];

        for (int i = 0; i < input3.Length; i++)
        {
            inputArray3[i] = input3[i];
            if (input3[i] == "1")
            {
                x += 0;
            }
        }

        if (inputArray3[0] == "1" || inputArray3[4] == "1")
        {
            y = 2;
        }
        else if (inputArray3[2] == "1")
        {
            y = 0;
        }
        else if (inputArray3[1] == "1" || inputArray3[3] == "1")
        {
            y = 1;
        }

        // input-4
        string[] input4 = Console.ReadLine().Split(' ');
        string[] inputArray4 = new string[input4.Length];

        for (int i = 0; i < input4.Length; i++)
        {
            inputArray4[i] = input4[i];
            if (input4[i] == "1")
            {
                x = 1;
            }
        }

        if (inputArray4[0] == "1" || inputArray4[4] == "1")
        {
            y = 2;
        }
        else if (inputArray4[2] == "1")
        {
            y = 0;
        }
        else if (inputArray4[1] == "1" || inputArray4[3] == "1")
        {
            y = 1;
        }

        // input-5
        string[] input5 = Console.ReadLine().Split(' ');
        string[] inputArray5 = new string[input5.Length];

        for (int i = 0; i < input5.Length; i++)
        {
            inputArray5[i] = input5[i];
            if (input5[i] == "1")
            {
                x = 2;
            }
        }

        if (inputArray5[0] == "1" || inputArray5[4] == "1")
        {
            y = 2;
        }
        else if (inputArray5[2] == "1")
        {
            y = 0;
        }
        else if (inputArray5[1] == "1" || inputArray5[3] == "1")
        {
            y = 1;
        }

        Console.WriteLine($"{x + y}");

    }
}