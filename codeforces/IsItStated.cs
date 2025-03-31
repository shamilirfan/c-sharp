using System;

class IsItStated
{
    public static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < input1; i++)
        {
            string input2 = Console.ReadLine();

            if (input2.Contains("it"))
            {
                Console.WriteLine($"YES");
            }
            else
            {
                Console.WriteLine($"NO");
            }
        }
    }
}