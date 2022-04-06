using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i].ToString());
            }
            while (stack.Count>0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
