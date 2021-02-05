using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class QuickSort
    {
        public static void Sort(List<int> list)
        {
            Sort(list, 0, list.Count - 1);
        }

        private static void Sort(List<int> list, int left, int right)
        {
            if (left <= right)
            {
                int pivot = Partition(list, left, right);
                Sort(list, left, pivot - 1);
                Sort(list, pivot + 1, right);
            }
        }

        private static int Partition(List<int> list, int left, int right)
        {
            throw new NotImplementedException();
        }
    }
}
