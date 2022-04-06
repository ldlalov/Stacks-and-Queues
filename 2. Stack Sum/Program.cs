using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack1 = new Stack<int>();
            for (int i = 0; i < integers.Length; i++)
            {
                stack1.Push(integers[i]);
            }
            string command;
            while ((command = Console.ReadLine()).ToLower() != "end")
            {
                string[] cmd = command.Split();
                string cmd1 = cmd[0].ToLower();
                switch (cmd1)
                {
                    case "add":
                        int n1 = int.Parse(cmd[1]);
                        int n2 = int.Parse(cmd[2]);
                        stack1.Push(n1);
                        stack1.Push(n2);
                        break;
                    case "remove":
                        int count = int.Parse(cmd[1]);
                        for (int i = 0; i < count; i++)
                        {
                            if (stack1.Count>=count)
                            {
                        stack1.Pop();
                            }
                        }
                        break;
                }
            }
            int sum = 0;
            while (stack1.Count>0)
            {
                sum += stack1.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
