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
            int[] testArr1 = {5, 1, 9, 3, 2, 6, 7, 0, 4, 8};
            int[] testArr1000 = new int[1000];
            int[] testArr100000 = new int[100000];

            Random rnd = new Random();

            for (int i = 0; i < testArr1000.Length; i++)
            {
                testArr1000[i] = rnd.Next(1000);
            }
            

            // Test on the basic sorts.
            RunTimedTest(new InsertionSort(), testArr1000);

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

            Console.Write("Test Array for " + sorter.GetType().Name + ": \n");
            PrintArray(testArray);
            Console.Write("\n");

            PrintArray(sorter.Sort(testArray));
            Console.Write("\n");

            timer.Stop();

            Console.WriteLine("Elapsed Time: " + timer.ElapsedMilliseconds);
        }
    }
}
