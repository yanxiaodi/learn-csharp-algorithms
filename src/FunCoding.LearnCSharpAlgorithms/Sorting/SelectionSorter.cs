using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding.LearnCSharpAlgorithms.Sorting
{
    public class SelectionSorter
    {
        #region selection-sort

        public int CallSelectionSort()
        {
            int[] numbers = { 12, 34, 5, 6, 23, 67, 48, 19, 29, 87, 25 };
            SelectionSort(numbers);
            Console.WriteLine($"The sorted array is {string.Join(',', numbers)}");
            return 0;
        }

        public void SelectionSort(int[] list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            if (list.Length <= 1)
            {
                return;
            }

            for (int i = 0; i < list.Length; i++)
            {
                var min = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j] < list[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    var temp = list[i];
                    list[i] = list[min];
                    list[min] = temp;
                }
            }
        }

        #endregion


        #region selection-sort-descending

        public int CallSelectionSortDescending()
        {
            int[] numbers = { 12, 34, 5, 6, 23, 67, 48, 19, 29, 87, 25 };
            SelectionSort(numbers);
            Console.WriteLine($"The sorted array is {string.Join(',', numbers)}");
            return 0;
        }

        public void SelectionSortDescending(int[] list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            if (list.Length <= 1)
            {
                return;
            }

            for (int i = 0; i < list.Length; i++)
            {
                var max = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j] > list[max])
                    {
                        max = j;
                    }
                }
                if (max != i)
                {
                    var temp = list[i];
                    list[i] = list[max];
                    list[max] = temp;
                }
            }
        }
        #endregion

    }
}
