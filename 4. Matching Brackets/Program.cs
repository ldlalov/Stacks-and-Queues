using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> brackets = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "(")
                {
                    brackets.Push(i);
                }
                else if (input[i].ToString() == ")")
                {
                    int start = brackets.Pop();
                    Console.WriteLine(input.Substring(start, i - start +1));
                }
            }
        }
    }
}
