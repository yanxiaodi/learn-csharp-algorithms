using System;
using System.Collections.Generic;
using System.Text;
using FunCoding.LearnCSharpAlgorithms.Warmup;
using Xunit;

namespace FunCoding.LearnCSharpAlgorithms.UnitTests.Warmup
{
    public static class GreatestCommonDivisorTest
    {
        [Fact]
        public static void DoTest()
        {
            Assert.Equal(61232, new GreatestCommonDivisor().CalculateGreatestCommonDivisorNaive(3918848L, 1653264L));
            Assert.Equal(17657, new GreatestCommonDivisor().CalculateGreatestCommonDivisorNaive(28851538L, 1183019L));

            Assert.Equal(61232, new GreatestCommonDivisor().CalculateGreatestCommonDivisorEuclidean(3918848L, 1653264L));
            Assert.Equal(17657, new GreatestCommonDivisor().CalculateGreatestCommonDivisorEuclidean(28851538L, 1183019L));

        }
    }
}
