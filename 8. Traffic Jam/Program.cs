using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsPassed = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string input;
            int passed = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    for (int i = 0; i < carsPassed; i++)
                    {
                        if (cars.Count>0)
                        {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        passed++;

                        }
                    }
                }
            }
            Console.WriteLine($"{passed} cars passed the crossroads.");
        }
    }
}
