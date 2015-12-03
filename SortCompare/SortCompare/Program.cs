using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortCompare.Algorithms;
using System.Diagnostics;

namespace SortCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr100000 = GetRandomValues(10000);

            
            

            // Test on the basic sorts.
            RunTimedTest(new InsertionSort(), testArr100000);
            RunTimedTest(new SelectionSort(), testArr100000);
            RunTimedTest(new BubbleSort(), testArr100000);

            Console.Read();
        }

        private static void PrintArray(int[] pArray)
        {
            foreach (var item in pArray)
            {
                Console.Write(item.ToString() + " ");
            }
        }

        private static void RunTimedTest(ISortCompare sorter, int[] testArray)
        {
            Stopwatch timer = Stopwatch.StartNew();

            /*Console.Write("Test Array for " + sorter.GetType().Name + ": \n");
            PrintArray(testArray);
            Console.Write("\n");

            PrintArray(sorter.Sort(testArray));
            Console.Write("\n"); */
            sorter.Sort(testArray);
            timer.Stop();

            Console.WriteLine("Elapsed Time: " + timer.ElapsedMilliseconds);
        }

        private static int[] GetRandomValues(int number)
        {
            Random rnd = new Random();
            int[] output = new int[number];

            for (int i = 0; i < number; i++)
            {
                output[i] = rnd.Next(number);
            }

            return output;
        }
    }
}
