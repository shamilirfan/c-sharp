using System;

class InsertionSort
{
	public static void Main(string[] args)
	{
		int[] arr = new int[10] { 5, 2, 9, 8, 7, 1, 3, 4, 6, 10 };
		int i, j, temp;

		// 1. Ascending Order
		for (i = 1; i < arr.Length - 1; i += 1)
		{
			temp = arr[i];
			j = i - 1;

			while (j >= 0 && arr[j] > temp)
			{
				arr[j + 1] = arr[j];
				j -= 1;
			}
			arr[j + 1] = temp;
		}

		foreach (int item in arr)
			Console.Write($"{item} ");


		// 2. Descending Order

		// int[] arr = new int[10] { 5, 2, 9, 8, 7, 1, 3, 4, 6, 10 };
		// int i, j, temp;

		// for (i = 0; i < arr.Length; i += 1)
		// {
		// 	temp = arr[i];
		// 	j = i - 1;

		// 	while (j >= 0 && arr[j] < temp)
		// 	{
		// 		arr[j + 1] = arr[j];
		// 		j -= 1;
		// 	}
		// 	arr[j + 1] = temp;
		// }

		// foreach (int item in arr)
		// 	Console.Write($"{item} ");

	}
}