using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class PlusOrMinus
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < a; i += 1)
        {
            string[] b = Console.ReadLine().Split(' ');
            int[] c = new int[b.Length];

            for (int ii = 0; ii < b.Length; ii++)
            {
                c[ii] = int.Parse(b[ii]);
            }
            if (c[0] + c[1] == c[2])
            {
                Console.WriteLine($"+");
            }
            else
            {
                Console.WriteLine($"-");
            }
        }

    }
}