using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortCompare.Algorithms
{
    class SelectionSort : ISortCompare
    {
        public SelectionSort()
        {

        }

        public int[] Sort(int[] unorderedArray)
        {
            if (unorderedArray.Length <= 1)
                return unorderedArray;

            for (int i = 0; i < unorderedArray.Length; i++)
            {
                int swap = unorderedArray[i];

                int lowest = unorderedArray[i];
                int lowestIndex = i;

                for (int j = i; j < unorderedArray.Length; j++)
                {                    
                    if (unorderedArray[j] < lowest)
                    {
                        lowest = unorderedArray[j];
                        lowestIndex = j;
                    }
                }

                unorderedArray[i] = lowest;
                unorderedArray[lowestIndex] = swap;
            }

            return unorderedArray;
        }
    }
}
