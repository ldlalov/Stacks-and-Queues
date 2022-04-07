using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> children = new Queue<string>(Console.ReadLine().Split(' '));
            int turns = int.Parse(Console.ReadLine());
            while (children.Count > 1)
            {

                for (int i = 1; i < turns; i++)
                {
                    string temp = children.Dequeue();
                    children.Enqueue(temp);
                }
                Console.WriteLine($"Removed {children.Dequeue()}");
            }
            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
