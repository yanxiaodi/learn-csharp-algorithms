using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FunCoding.LearnCSharpAlgorithms.Sorting
{
    public class InsertionSorter
    {
        #region insertion-sort
        public int CallInsertionSort()
        {
            int[] numbers = { 12, 34, 5, 6, 23, 67, 48, 19, 29, 87, 25 };
            InsertionSort(numbers);
            Console.WriteLine($"The sorted array is {string.Join(',', numbers)}");
            return 0;
        }
        public void InsertionSort(int[] list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            if (list.Length <= 1)
            {
                return;
            }

            for (int i = 1; i < list.Length; i++)
            {
                var temp = list[i];
                var j = i;
                while (j > 0 && list[j - 1] > temp)
                {
                    list[j] = list[j - 1];
                    j--;
                }

                list[j] = temp;
            }
        }
        #endregion

        #region insertion-sort-descending
        public int CallInsertionSortDescending()
        {
            int[] numbers = { 12, 34, 5, 6, 23, 67, 48, 19, 29, 87, 25 };
            InsertionSortDescending(numbers);
            Console.WriteLine($"The sorted array is {string.Join(',', numbers)}");
            return 0;
        }

        public void InsertionSortDescending(int[] list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            if (list.Length <= 1)
            {
                return;
            }

            for (int i = 1; i < list.Length; i++)
            {
                var temp = list[i];
                var j = i;
                while (j > 0 && list[j - 1] < temp)
                {
                    list[j] = list[j - 1];
                    j--;
                }

                list[j] = temp;
            }
        }
        #endregion

    }
}
