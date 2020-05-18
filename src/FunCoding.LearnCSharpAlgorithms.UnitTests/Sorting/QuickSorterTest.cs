using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FunCoding.LearnCSharpAlgorithms.Sorting;
using Xunit;

namespace FunCoding.LearnCSharpAlgorithms.UnitTests.Sorting
{
    public static class QuickSorterTest
    {
        [Fact]
        public static void DoTestForLomutoPartition()
        {
            for (int count = 0; count < 1000; count++)
            {
                Random random = new Random(DateTime.Now.Millisecond);
                int[] numbers = new int[1000];
                int[] numbersForTest = new int[1000];
                for (int i = 0; i < 1000; i++)
                {
                    numbers[i] = numbersForTest[i] = random.Next(0, 1000);
                }

                var result = numbersForTest.OrderBy(x => x).ToArray();

                new QuickSorter().QuickSortWithLomutoPartition(numbers);
                Assert.True(numbers.SequenceEqual(result));
            }
        }

        [Fact]
        public static void DoTestForHoarePartition()
        {
            for (int count = 0; count < 1000; count++)
            {
                Random random = new Random(DateTime.Now.Millisecond);
                int[] numbers = new int[1000];
                int[] numbersForTest = new int[1000];
                for (int i = 0; i < 1000; i++)
                {
                    numbers[i] = numbersForTest[i] = random.Next(0, 1000);
                }

                //int[] numbers =
                //    {678, 777, 454, 725, 166, 467, 803, 964, 329, 586, 678, 488, 742, 748, 973, 631, 173, 195, 69, 348};
                //int[] numbersForTest =
                //    {678, 777, 454, 725, 166, 467, 803, 964, 329, 586, 678, 488, 742, 748, 973, 631, 173, 195, 69, 348};
                new QuickSorter().QuickSortWithHoarePartition(numbers);
                var result = numbersForTest.OrderBy(x => x).ToArray();

                Assert.True(numbers.SequenceEqual(result));
            }
        }

    }
}
