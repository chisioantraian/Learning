using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class BinarySearch
    {
        public static int Search(List<int> list, int num)
        {
            //return Search(list, 0, list.Count, num);
            return IterativeSearch(list, num);
        }

        private static int Search(List<int> list, int start, int end, int num)
        {
            if (end < start)
            {
                return -1;
            }
            int mid = (start + end) / 2;
            if (list[mid] == num)
            {
                return mid;
            }
            else if (num < list[mid])
            {
                return Search(list, start, mid - 1, num);
            }
            else
            {
                return Search(list, mid + 1, end, num);
            }
        }

        private static int IterativeSearch(List<int> list, int num)
        {
            int start = 0;
            int end = list.Count - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (list[mid] == num)
                {
                    return mid;
                }
                else if (num < list[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }

        public static void RunAlg()
        {
            List<int> nums = new List<int>{ 10, 20, 30, 50, 70, };
            int num = 70;
            int index = Search(nums, num);

            if (index == -1)
            {
                Console.WriteLine($"{num} not found in list");
            }
            else
            {
                Console.WriteLine($"{num} found at index {index}");
            }
        }
    }
}
