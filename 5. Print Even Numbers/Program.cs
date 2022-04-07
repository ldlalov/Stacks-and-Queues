using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue1 = new Queue<int>();
            foreach (var item in integers)
            {
                if (item%2 == 0)
                {
                    queue1.Enqueue(item);
                }
            }
                Console.WriteLine($"{string.Join(", ",queue1)}");
        }
    }
}
