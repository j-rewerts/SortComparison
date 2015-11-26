using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortCompare.Algorithms
{
    /// <summary>
    /// Insertion Sort sorts an array by placing each sequential integer into a sorted subarray.
    /// From 0 to i is the sorted subarray and from i + 1 to n is the unsorted subarray.
    /// Best O(n), Average O(n^2), Worst O(n^2)
    /// </summary>
    class InsertionSort : ISortCompare
    {
        public InsertionSort()
        {

        }

        public int[] Sort(int[] unorderedArray)
        {
            if (unorderedArray.Length <= 1) 
                return unorderedArray;

            for (int i = 1; i < unorderedArray.Length; i++)
            {
                int key = unorderedArray[i];

                for (int j = i - 1; j >= 0; j--)
                {
                    if (unorderedArray[j] > key)
                    {
                        unorderedArray[j + 1] = unorderedArray[j];
                        unorderedArray[j] = key;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return unorderedArray;
        }        
    }
}
