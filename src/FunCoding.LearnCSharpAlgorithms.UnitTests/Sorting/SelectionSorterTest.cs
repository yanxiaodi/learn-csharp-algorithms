using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FunCoding.LearnCSharpAlgorithms.Sorting;
using Xunit;

namespace FunCoding.LearnCSharpAlgorithms.UnitTests.Sorting
{
    public static class SelectionSorterTest
    {
        [Fact]
        public static void DoTest()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int[] numbers = new int[10000];
            int[] numbersForTest = new int[10000];
            for (int i = 0; i < 1000; i++)
            {
                numbers[i] = numbersForTest[i] = random.Next(0, 10000);
            }
            new SelectionSorter().SelectionSort(numbers);
            Assert.True(numbers.SequenceEqual(numbersForTest.OrderBy(x => x).ToArray()));

            new SelectionSorter().SelectionSortDescending(numbers);
            Assert.True(numbers.SequenceEqual(numbersForTest.OrderByDescending(x => x).ToArray()));


        }
    }
}
