using System;
using System.Collections.Generic;
using System.Drawing;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Queue<string> queue = new Queue<string>();
            while ((input = Console.ReadLine()) != "End")
            {
                if (input != "Paid")
                {
                    queue.Enqueue(input);
                }
                else
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
}
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
