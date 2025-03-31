using System;

class Solution
{
	public static void Main(string[] args)
	{
		string? s = Console.ReadLine();
		List<int> list = new List<int>();

		for (int i = 0; i < s.Length; i += 1)
		{
			if (s[i] == Convert.ToChar("I"))
				list.Add(1);
			else if (s[i] == Convert.ToChar("V"))
				list.Add(5);
			else if (s[i] == Convert.ToChar("X"))
				list.Add(10);
			else if (s[i] == Convert.ToChar("L"))
				list.Add(50);
			else if (s[i] == Convert.ToChar("C"))
				list.Add(100);
			else if (s[i] == Convert.ToChar("D"))
				list.Add(500);
			else if (s[i] == Convert.ToChar("M"))
				list.Add(1000);
		}

		int sum = 0;

		for (int i = 1; i < list.Count(); i++)
		{
			if (list[i - 1] > list[i] || list[i - 1] == list[i])
				sum += list[i - 1];
			else if (list[i - 1] < list[i])
			{
				sum += list[i] - list[i - 1];
				i++;
			}

			if (i == list.Count() - 1)
			{
				if (list[list.Count() - 2] == list[list.Count() - 1] || list[list.Count() - 2] > list[list.Count() - 1])
					sum += list[list.Count() - 1];
				else
					sum += list[list.Count() - 1] - list[list.Count() - 2];
			}
		}

		if (s.Length == 1 && s == "I")
			sum += 1;
		else if (s.Length == 1 && s == "V")
			sum += 5;
		else if (s.Length == 1 && s == "X")
			sum += 10;
		else if (s.Length == 1 && s == "L")
			sum += 50;
		else if (s.Length == 1 && s == "C")
			sum += 100;
		else if (s.Length == 1 && s == "D")
			sum += 500;
		else if (s.Length == 1 && s == "M")
			sum += 1000;

		Console.Write(sum);
	}
}