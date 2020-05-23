using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace FunCoding.LearnCSharpAlgorithms.Sorting
{
    public class QuickSorter
    {
        #region quick-sort-lomuto-partition

        public int CallQuickSortWithLomutoPartition()
        {
            int[] numbers = { 12, 34, 5, 6, 23, 67, 48, 19, 29, 87, 25 };
            QuickSortWithLomutoPartition(numbers);
            Console.WriteLine($"The sorted array is {string.Join(',', numbers)}");
            return 0;
        }

        public void QuickSortWithLomutoPartition(int[] list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            if (list.Length <= 1)
            {
                return;
            }
            InternalQuickSortWithLomutoPartition(list, 0, list.Length - 1);
        }

        public void InternalQuickSortWithLomutoPartition(int[] list, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                var pivotIndex = LomutoPartition(list, leftIndex, rightIndex);
                InternalQuickSortWithLomutoPartition(list, leftIndex, pivotIndex - 1);
                InternalQuickSortWithLomutoPartition(list, pivotIndex + 1, rightIndex);
            }
        }

        public int LomutoPartition(int[] list, int leftIndex, int rightIndex)
        {
            var pivotIndex = rightIndex;
            var pivot = list[rightIndex];
            var i = leftIndex;
            for (int j = leftIndex; j < rightIndex; j++)
            {
                if (list[j] < pivot)
                {
                    var temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                    i += 1;
                }
            }
            var temp2 = list[i];
            list[i] = list[pivotIndex];
            list[pivotIndex] = temp2;
            return i;
        }

        #endregion

        #region quick-sort-hoare-partition
        public int CallQuickSortWithHoarePartition()
        {
            int[] numbers = { 12, 34, 5, 6, 23, 67, 48, 19, 29, 87, 25 };
            QuickSortWithHoarePartition(numbers);
            Console.WriteLine($"The sorted array is {string.Join(',', numbers)}");
            return 0;
        }

        public void QuickSortWithHoarePartition(int[] list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            if (list.Length <= 1)
            {
                return;
            }
            InternalQuickSortWithHoarePartition(list, 0, list.Length - 1);
        }
        public void InternalQuickSortWithHoarePartition(int[] list, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                var pivotIndex = HoarePartition(list, leftIndex, rightIndex);
                InternalQuickSortWithHoarePartition(list, leftIndex, pivotIndex - 1);
                InternalQuickSortWithHoarePartition(list, pivotIndex + 1, rightIndex);
            }
        }
        public int HoarePartition(int[] list, int leftIndex, int rightIndex)
        {
            var pivot = list[rightIndex];
            var i = leftIndex;
            var j = rightIndex - 1;
            while (true)
            {
                while (i < list.Length && list[i] < pivot)
                {
                    i++;
                }

                while (j >= 0 && list[j] > pivot)
                {
                    j--;
                }

                if (i >= j)
                {
                    var temp = list[i];
                    list[i] = list[rightIndex];
                    list[rightIndex] = temp;
                    return i;
                }
                var temp2 = list[i];
                list[i] = list[j];
                list[j] = temp2;
                i++;
                j--;
            }
        }

        #endregion

    }
}
