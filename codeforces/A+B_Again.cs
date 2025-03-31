using System;

class A+B_Again
{
	public static void Main(string[] args)
{
	int a = Convert.ToInt32(Console.ReadLine());

	for (int i = 0; i < a; i += 1)
	{
		char[] chars = Console.ReadLine().ToCharArray();
		List<String> strings = new List<string>();

		foreach (var item in chars)
			strings.Add(Convert.ToString(item));

		//
		List<int> ints = new List<int>();

		foreach (var item in strings)
			ints.Add(Convert.ToInt32(item));

		for (int j = 1; j < ints.Count; j += 1)
			Console.WriteLine($"{ints[j - 1] + ints[j]}");
	}

}
}