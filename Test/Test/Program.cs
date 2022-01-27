using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            queue.Enqueue("Task1");
            queue.Enqueue("Task2");
            queue.Enqueue("Task3");

            var task = queue.Dequeue();

            var peekedItask = queue.Peek();

            queue.Clear();
            ReadLine();
        }
    }
}
