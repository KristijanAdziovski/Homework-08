using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integersList = new List<int>();
            integersList.Add(2);
            integersList.Add(22);
            integersList.Add(36);
            integersList.Add(125);
            integersList.Add(95);
            integersList.Add(75);
            integersList.Add(259);
            integersList.Add(789);
            integersList.Add(1);
            integersList.Add(963);


            foreach(int number in integersList)
            {
                Console.WriteLine(number);
            }

            List<int> squaredNumList = integersList.Select(n => n * n).ToList();
            foreach(int number in squaredNumList)
            {
                Console.WriteLine(num);
            }
        }
    }
}
