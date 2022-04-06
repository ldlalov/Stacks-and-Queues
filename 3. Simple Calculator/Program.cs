using System;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Array.Reverse(input);
            Stack<string> stack1 = new Stack<string>();
            for (int i = 0; i < input.Length; i++)
            {
                stack1.Push(input[i]);
            }
            while (stack1.Count>1)
            {
                int result = 0;
                int n1 = int.Parse(stack1.Pop());
                string sign = stack1.Pop();
                int n2 = int.Parse(stack1.Pop());
                if (sign == "+")
                {
                    result = n1 + n2;
                }
                else
                {
                    result = n1 - n2;
                }
                stack1.Push(result.ToString());
            }
            Console.WriteLine(stack1.Pop());
        }
    }
}
