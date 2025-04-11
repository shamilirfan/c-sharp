using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;

class PushAndPop
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

        /* Pop method removes and returns items from the top value of the stack */
        Console.WriteLine($"Pop = {stack1.Pop()}");

        foreach (object item in stack1)
        {
            Console.WriteLine($"{item}");
        }


    }
}
