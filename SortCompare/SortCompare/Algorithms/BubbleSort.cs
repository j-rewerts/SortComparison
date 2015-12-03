using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortCompare.Algorithms
{
    class BubbleSort : ISortCompare
    {
        public BubbleSort()
        {

        }

        public int[] Sort(int[] unorderedArray)
        {
            for (int i = 0; i < unorderedArray.Length; i++)
            {
                for (int j = 0; j < unorderedArray.Length - 1; j++)
                {
                    if (unorderedArray[j] > unorderedArray[j + 1])
                    {
                        int tempVal = unorderedArray[j + 1];
                        unorderedArray[j + 1] = unorderedArray[j];
                        unorderedArray[j] = tempVal;
                    }
                }                
            }

            return unorderedArray;
        }
    }
}
