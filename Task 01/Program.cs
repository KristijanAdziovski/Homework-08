using System;
using System.Collections.Generic;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> intQueue = new Queue<int>();
            Console.WriteLine("Input 1 number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input 2 number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input 3 number");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input 4 number");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input 5 number");
            int num5 = int.Parse(Console.ReadLine());
            intQueue.Enqueue(num1);
            intQueue.Enqueue(num2);
            intQueue.Enqueue(num3);
            intQueue.Enqueue(num4);
            intQueue.Enqueue(num5);

            foreach(int number in intQueue)
            {
                Console.WriteLine(number);
            }

        }
    }
}
