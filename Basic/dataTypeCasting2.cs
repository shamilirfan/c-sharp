using System;

class dataTypeCasting2
{
    public static void Main(string[] args)
    {
        string input = "20";
        bool isSuccess = int.TryParse(input, out int r);

        Console.WriteLine(isSuccess); // isSuccess return bool
        Console.WriteLine(r); // result will store in r variable 

    }
}