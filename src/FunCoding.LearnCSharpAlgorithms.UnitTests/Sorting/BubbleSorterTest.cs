﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using FunCoding.LearnCSharpAlgorithms.Sorting;
using FunCoding.LearnCSharpAlgorithms.Warmup;
using Xunit;

namespace FunCoding.LearnCSharpAlgorithms.UnitTests.Sorting
{
    public static class BubbleSorterTest
    {
        [Fact]
        public static void DoTest()
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

                new BubbleSorter().BubbleSort(numbers);
                Assert.True(numbers.SequenceEqual(numbersForTest.OrderBy(x => x).ToArray()));

                new BubbleSorter().BubbleSortDescending(numbers);
                Assert.True(numbers.SequenceEqual(numbersForTest.OrderByDescending(x => x).ToArray()));
            }
        }
    }
}
