using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;

class Count
{
    public static void Main(string[] args)
    {

        Stack stack1 = new Stack();
        stack1.Push("Hello!");
        stack1.Push(1);
        stack1.Push(2);
        stack1.Push(3);
        stack1.Push(56.84);
        stack1.Push(null);
        stack1.Push('A');
        stack1.Push(true);

        /* Returns the total count of elements in the stack */
        Console.WriteLine($"Count = {stack1.Count}");

        foreach (object item in stack1)
        {
            Console.WriteLine($"{item}");
        }



    }
}