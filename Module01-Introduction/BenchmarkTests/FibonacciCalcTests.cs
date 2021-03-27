using Dotnetos.AsyncExpert.Homework.Module01.Benchmark;

using System;
using System.Collections.Generic;

using Xunit;

namespace BenchmarkTests
{
    public class FibonacciCalcTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void Recursive(ulong n, ulong expected)
        {
            Assert.Equal(expected, new FibonacciCalc().Recursive(n));
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void RecursiveWithMemoization(ulong n, ulong expected)
        {
            Assert.Equal(expected, new FibonacciCalc().RecursiveWithMemoization(n));
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void Iterative(ulong n, ulong expected)
        {
            Assert.Equal(expected, new FibonacciCalc().Iterative(n));
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                yield return new object[] { 1, 1 };
                yield return new object[] { 2, 1 };
                yield return new object[] { 3, 2 };
                yield return new object[] { 4, 3 };
                yield return new object[] { 5, 5 };
                yield return new object[] { 15, 610 };
                yield return new object[] { 35, 9227465 };
            }
        }
    }
}
