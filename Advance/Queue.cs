using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;

class Queue
{
    public static void Main(string[] args)
    {
        // Queue ( Non-Generic Collection )
        /* Queue meaning: a line or sequence of people or others.
           Queue stores the elements in FIFO style, it is exactly opposite of the Stack collection
        */
        /* FIFO - First In, First Out */

        Queue queue = new Queue();
        queue.Enqueue("Hello, World!");
        queue.Enqueue('A');
        queue.Enqueue(null);
        queue.Enqueue(false);
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(22.65);

        foreach (object item in queue)
        {
            Console.WriteLine($"{item}");
        }

    }
}