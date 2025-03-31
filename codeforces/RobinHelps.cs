using System;

class RobinHelps
{
	public static void Main(string[] args)
	{
		int input1 = Convert.ToInt32(Console.ReadLine());

		for (int i = 0; i < input1; i++)
		{
			int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int[] input3 = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int temp = 0, count = 0;

			for (int j = 0; j < input3.Length; j++)
			{
				if (input3[j] != 0 && input3[j] >= input2[1])
					temp += input3[j];
				else if (temp > 0 && input3[j] == 0)
				{
					temp--;
					count++;
				}
			}

			Console.WriteLine($"{count}");
		}

	}
}