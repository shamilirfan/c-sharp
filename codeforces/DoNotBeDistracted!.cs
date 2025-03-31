using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class DoNotBeDistracted
{
    public static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < input1; i++)
        {
            int input2 = Convert.ToInt32(Console.ReadLine());
            string input3 = Console.ReadLine() + "+";
            string[] arr = new string[input2];
            int index = 0;

            for (int j = 1; j < input3.Length; j++)
            {
                if (input3[j - 1] != input3[j] && index < input2)
                {
                    arr[index] = input3[j - 1].ToString();
                    index++;
                }
            }

            bool isDistinct = arr.Take(index).Distinct().Count() == index;

            if (isDistinct == true)
                Console.WriteLine($"YES");
            else
                Console.WriteLine($"NO");
        }

    }
}
