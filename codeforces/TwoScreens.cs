using System;

class TwoScreens
{
    public static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < input1; i++)
        {
            string? input2 = Console.ReadLine();
            string? input3 = Console.ReadLine();
            int minLen = Math.Min(input2!.Length, input3!.Length);
            int similar = 0,
                count = 0;

            for (int j = 0; j < minLen; j++)
            {
                if (input2[j] == input3![j])
                    similar += 1;
                else
                    break;
            }

            for (int k = similar; k < input3!.Length; k++)
                count += 1;

            if (similar == 0)
                count += input2.Length;
            else
                count += 1 + input2.Length;

            Console.WriteLine(count);
        }
    }
}
