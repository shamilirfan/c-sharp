using System;

class NormalProblem
{
    public static void Main(string[] args)
    {
        int input1 = int.Parse(Console.ReadLine());

        for (int i = 0; i < input1; i++)
        {
            string? input2 = Console.ReadLine();
            string reverse = "";

            // reverse
            for (int j = input2!.Length - 1; j >= 0; j--)
                reverse = reverse + input2[j];

            // array
            string[] arr = new string[reverse.Length];

            for (int j = 0; j < reverse.Length; j++)
                arr[j] = reverse[j].ToString();

            // result
            string result = "";

            foreach (var item in arr)
            {
                if (item == "p")
                    result += "q";
                else if (item == "q")
                    result += "p";
                else
                    result += item;
            }

            Console.WriteLine(result);
        }
    }
}
