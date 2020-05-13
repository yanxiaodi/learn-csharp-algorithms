using System;
using System.Collections.Generic;
using System.Text;
using FunCoding.LearnCSharpAlgorithms.Warmup;
using Xunit;

namespace FunCoding.LearnCSharpAlgorithms.UnitTests.Warmup
{
    public static class CalculateSumTest
    {
        [Fact]
        public static void DoTest()
        {
            Assert.Equal(5050, new CalculateSum().CalculateSumNaive(100));
            Assert.Equal(5050, new CalculateSum().CalculateSumByGauss(100));

            Assert.Throws<ArgumentException>(() => new CalculateSum().CalculateSumNaive(1));
            Assert.Throws<ArgumentException>(() => new CalculateSum().CalculateSumByGauss(1));

        }
    }
}
