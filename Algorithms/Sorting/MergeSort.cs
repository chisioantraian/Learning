using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class MergeSort
    {
        public static void Sort(List<int> list)
        {
            Sort(list, 0, list.Count - 1);
        }
        private static void Sort(List<int> list, int left, int right)
        {
            if (left < right)
            {
                int m = (left + right) / 2;
                Sort(list, left, m);
                Sort(list, m + 1, right);
                Merge(list, left, m, right);
            }
        }

        private static void Merge(List<int> list, int left, int m, int right)
        {
            //todo
        }
    }
}
