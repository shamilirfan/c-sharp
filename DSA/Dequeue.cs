using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;

class Dequeue
{
    public static void Main(string[] args)
    {
        Queue queue = new Queue();
        queue.Enqueue("Hello, World!");
        queue.Enqueue('A');
        queue.Enqueue(null);
        queue.Enqueue(false);
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(22.65);

        // Dequeue removes and returns an item from the of beginnig queue 
        queue.Dequeue();

        foreach (object item in queue)
        {
            Console.WriteLine($"{item}");
        }


    }
}