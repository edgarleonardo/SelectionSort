using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class SortAlgorithms<T> where T : IComparable<T>
    {
        public void SortSelection(T[] items)
        {
            int indexInfo = 0;
            while (indexInfo < items.Length)
            {
                int smallestInt = FindSmallestInt(items, indexInfo);
                var temp = items[indexInfo];
                items[indexInfo] = items[smallestInt];
                items[smallestInt] = temp;
                indexInfo++;
            }
        }

        private int FindSmallestInt(T[] items, int indextorganized)
        {
            int smallestInt = indextorganized;
            T ChoosenValue = items[indextorganized];
            for (int count = indextorganized; count < items.Length; count++)
            {
                if (items[count].CompareTo(ChoosenValue) < 0)
                {
                    smallestInt = count;
                    ChoosenValue = items[count];
                }
            }
            return smallestInt;
        }
    }
}
