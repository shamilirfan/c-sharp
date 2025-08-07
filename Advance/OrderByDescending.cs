using System;

class OrderByDescending
{
    int[] num2 = new int[5] { 1, 2, 3, 4, 5 };

    var y = num2.OrderByDescending(b => b); // use of OrderByDescending

    // foreach (var item in y)
    // {
    // Console.Write($"\n{item}");
    // }
}
