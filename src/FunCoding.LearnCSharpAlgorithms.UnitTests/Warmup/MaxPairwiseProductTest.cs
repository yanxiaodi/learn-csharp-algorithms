using System;
using System.Collections.Generic;
using System.Text;
using FunCoding.LearnCSharpAlgorithms.Warmup;
using Xunit;

namespace FunCoding.LearnCSharpAlgorithms.UnitTests.Warmup
{
    public static class MaxPairwiseProductTest
    {
        [Fact]
        public static void DoTest()
        {
            int[] array = { 7, 5, 14, 2, 8, 8, 10, 1, 2, 3, 12, 5, 17, 20, 35, 19 };
            Assert.Equal(700, new MaxPairwiseProduct().MaxPairwiseProductNaive(array));
            Assert.Equal(700, new MaxPairwiseProduct().MaxPairwiseProductFast(array));
        }
    }
}
