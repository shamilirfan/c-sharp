using System;

class dataTypeCasting1
{
    public static void Main(string[] args)
    {
        int int1 = 5;
        // double double1 = 5.32;

        // int variable assign in the double variable. it is allowed because double is greater than int.
        double assign1 = int1;
        // Console.WriteLine(assign2);


        // double variable assign in the int variable. it is not allowed because int is smaller than double.
        // int assign2 = double1;
        // Console.WriteLine(assign2);


        // data type convertion
        // Note :- data type conversion are tow types in c#
        // 1. implicit /  automatic conversion. char -> int -> long -> float -> double 
        // 2. explicit / menual conversion. double -> float -> long -> int -> char
        int a = 4;
        double b = 4.88;

        // int c = b; // not allowed

        int d = (int)b; // allowed because it is converted and example of explicit / menual conversion
        Console.WriteLine(d);

        // 1. implicit /  automatic conversion
        double e = a;
        Console.WriteLine(e);

        // menual convertion by built in method
        Console.WriteLine(Convert.ToString(a)); ;

        // 
        string number = "10";
        Console.WriteLine(int.Parse(number));
        Console.WriteLine(Convert.ToInt32(number));
        Console.WriteLine(Convert.ToInt16(number));


        //
        Console.WriteLine(int.TryParse(number, out int result));
        Console.WriteLine($"result= {result}");

    }
}