using System;

class BitwiseOpe
{
    public static void Main(string[] args)
    {
        // Bitwise Operator = &, |, ^, >>, <<, ! // those work with binary digit.

        int num1 = 15; // binary number of 15 = 1111
        int num2 = 12; /* binary number of 15 = 1100  1111 + 1100 = 12(in decimal) because one is false all is false in & operator */

        int result1 = num1 & num2;
        Console.WriteLine($"{num1} & {num2} = {result1}"); // 1111 & 1100 = 12

        // 
        int result2 = num1 | num2;
        Console.WriteLine($"{num1} | {num2} = {result2}"); /* 1111 + 1100 = 15(in decimal) because one is true all is true in | operator */

        //
        int result3 = num1 ^ num2;
        Console.WriteLine($"{num1} ^ {num2} = {result3}");

        //
        int result4 = num1 >> 2;
        Console.WriteLine($"{num1} >> {2} = {result4}");

        //
        int result5 = num1 << 2;
        Console.WriteLine($"{num1} << {2} = {result5}");
    }
}