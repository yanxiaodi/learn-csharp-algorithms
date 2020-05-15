using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding.LearnCSharpAlgorithms.Sorting
{
    public class BubbleSorter
    {

        #region bubble-sort

        public int CallBubbleSort()
        {
            int[] numbers = {12, 34, 5, 6, 23, 67, 48, 19, 29, 87, 25};
            BubbleSort(numbers);
            Console.WriteLine($"The sorted array is {string.Join(',',numbers)}");
            return 0;
        }

        public void BubbleSort(int[] list)
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
                for (int j = 0; j < list.Length - 1 - i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        var temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }
        #endregion


        #region bubble-sort-descending
        public int CallBubbleSortDescending()
        {
            int[] numbers = { 12, 34, 5, 6, 23, 67, 48, 19, 29, 87, 25 };
            BubbleSortDescending(numbers);
            Console.WriteLine($"The sorted array is {string.Join(',', numbers)}");
            return 0;
        }
        public void BubbleSortDescending(int[] list)
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
                for (int j = 0; j < list.Length - 1 - i; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        var temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }
        #endregion
    }
}
