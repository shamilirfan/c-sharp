using System;

class PrettyPermutations
{
	public static void Main(string[] args)
	{
		int input1 = Convert.ToInt32(Console.ReadLine());

		for (int i = 0; i < input1; i++)
		{
			int input2 = Convert.ToInt32(Console.ReadLine());
			int[] arr1 = new int[input2];

			for (int j = 1; j <= input2; j++)
				arr1[j - 1] = j;

			//
			int[] arr2 = new int[arr1.Length];

			if (arr1.Length % 2 == 0)
			{
				for (int k = 0; k < arr1.Length; k++)
				{
					arr2[k] = arr1[k + 1];
					arr2[k + 1] = arr1[k];
					k++;
				}

				foreach (int item in arr2)
				{
					Console.Write($"{item} ");
				}

				Console.WriteLine();
			}
			else if (arr1.Length != 3 && arr1.Length % 2 != 0)
			{
				for (int k = 0; k < arr1.Length - 1; k++)
				{
					arr2[k] = arr1[k + 1];
					arr2[k + 1] = arr1[k];
					k++;
				}

				for (int m = 0; m < arr2.Length - 3; m++)
				{
					Console.Write($"{arr2[m]} ");
				}

				for (int n = 0; n < 1; n++)
				{
					Console.Write($"{arr1[input2 - 2]} ");
					Console.Write($"{arr1[input2 - 1]} ");
					Console.Write($"{arr1[input2 - 3]} ");
				}

				Console.WriteLine();
			}
			else if (input2 == 3)
			{
				Console.Write($"{3} ");
				Console.Write($"{1} ");
				Console.Write($"{2} ");
			}
		}

	}
}