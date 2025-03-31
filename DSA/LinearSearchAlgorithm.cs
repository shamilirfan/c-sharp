using System;

class LinearSearchAlgorithm
{
	public static void Main(string[] args)
	{
		int input = Convert.ToInt32(Console.ReadLine());
		int[] arr = { 4, 7, 1, 3, 2, 5, 9, 8, 6, 10 };
		int found = 0;

		for (int i = 0; i < arr.Length; i += 1)
		{
			if (arr[i] == input)
			{
				Console.WriteLine($"Searching number is found. It's index number is - {i}");
				found += 1;
				break;
			}
		}

		if (found == 0)
			Console.WriteLine($"Not found!");

	}
}