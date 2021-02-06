using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
            if (left < right)
            {
                int pivot = Partition(list, left, right);
                Sort(list, left, pivot - 1);
                Sort(list, pivot + 1, right);
            }
        }

        private static int Partition(List<int> list, int left, int right)
        {
            int pivot = list[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (list[j] < pivot)
                {
                    i++;
                    Swap(list, i, j);
                }
            }

            i++;
            Swap(list, i, right);

            return i;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void Swap(List<int> list, int pos1, int pos2)
        {
            int temp = list[pos1];
            list[pos1] = list[pos2];
            list[pos2] = temp;
        }

        public static void RunAlg()
        {
            List<int> list = GenerateList();
            PrintList(list);
            Sort(list);
            PrintList(list);
        }

        private static List<int> GenerateList()
        {
            List<int> result = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                result.Add(random.Next() % 100);
            }
            return result;
        }

        private static void PrintList(List<int> list)
        {
            foreach (var el in list)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }

    }
}
