using System;
using System.Collections.Generic;
using System.Text;
using FunCoding.LearnCSharpAlgorithms.Warmup;
using Xunit;

namespace FunCoding.LearnCSharpAlgorithms.UnitTests.Warmup
{
    public static class FibonacciNumberTest
    {
        [Fact]
        public static void DoTest()
        {
            Assert.Equal(55, new FibonacciNumber().CalculateFibonacciNaive(10));
            Assert.Equal(6765, new FibonacciNumber().CalculateFibonacciNaive(20));

            Dictionary<int, int> note = new Dictionary<int, int>();
            Assert.Equal(55, new FibonacciNumber().CalculateFibonacciNote(10, note));
            note = new Dictionary<int, int>();
            Assert.Equal(6765, new FibonacciNumber().CalculateFibonacciNote(20, note));

            Assert.Equal(55, new FibonacciNumber().CalculateFibonacciArray(10));
            Assert.Equal(6765, new FibonacciNumber().CalculateFibonacciArray(20));

            Assert.Equal(55, new FibonacciNumber().CalculateFibonacciWithoutArray(10));
            Assert.Equal(6765, new FibonacciNumber().CalculateFibonacciWithoutArray(20));

            Assert.Throws<ArgumentException>(() => new FibonacciNumber().CalculateFibonacciNaive(- 1));
            Assert.Throws<ArgumentException>(() => new FibonacciNumber().CalculateFibonacciNaive(100));

            Assert.Throws<ArgumentException>(() => new FibonacciNumber().CalculateFibonacciArray(-1));
            Assert.Throws<ArgumentException>(() => new FibonacciNumber().CalculateFibonacciArray(100));

        }
    }
}
