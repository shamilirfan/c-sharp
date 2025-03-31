using System;

class RemoveSmallest
{
	public static void Main(string[] args)
	{
		int input1 = Convert.ToInt32(Console.ReadLine());

		for (int i = 0; i < input1; i++)
		{
			int input2 = Convert.ToInt32(Console.ReadLine());
			int[] input3 = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
			List<int> numbers = new List<int>();
			for (int j = 0; j < input2; j++)
				numbers.Add(input3[j]);

			// 1
			List<int> list = new List<int>();
			int count = 0;

			for (int x = 1; x < numbers.Count; x++)
			{
				for (int j = numbers[x - 1]; j < numbers[x]; j++)
				{
					count += 1;
				}
				list.Add(count);
				count = 0;
			}

			// 2
			int result = 0;

			foreach (int item in list)
			{
				if (item == 0 || item == 1)
					continue;
				else
					result++;
			}

			// result
			if (result == 0)
				Console.WriteLine($"YES");
			else
				Console.WriteLine($"NO");
		}

	}
}