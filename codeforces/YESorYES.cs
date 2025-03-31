using System;

class YESorYES
{
    public static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < input1; i += 1)
        {
            string input2 = Console.ReadLine();

            string a = input2 == "YES" || input2 == "yES" || input2 == "yes" || input2 == "Yes" || input2 == "YeS" || input2 == "YEs" || input2 == "YEs" || input2 == "yEs" || input2 == "yeS" ? "YES" : "NO";

            Console.WriteLine($"{a}");
        }

    }
}