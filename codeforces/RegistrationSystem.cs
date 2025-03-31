using System;

class RegistrationSystem
{
    public static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, int> a = new Dictionary<string, int>();

        for (int i = 0; i < input1; i++)
        {
            string? input2 = Console.ReadLine();

            if (a.ContainsKey(input2))
            {
                a[input2]++;
                Console.WriteLine($"{input2}{a[input2] - 1}");
            }
            else
            {
                a[input2] = 1;
                Console.WriteLine("OK");
            }
        }
    }
}