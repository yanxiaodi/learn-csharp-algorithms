// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using FunCoding.LearnCSharpAlgorithms.Sorting;
using FunCoding.LearnCSharpAlgorithms.UnionFind;
using FunCoding.LearnCSharpAlgorithms.UnionFind.Percolation;
using FunCoding.LearnCSharpAlgorithms.Warmup;

namespace FunCoding.LearnCSharpAlgorithms
{
    public class Program
    {
        static int Main(
            string region = null,
            string session = null,
            string package = null,
            string project = null,
            string[] args = null)
        {
            #region Main

            return region switch
            {
                // warm up
                "calculate-sum-naive" => new CalculateSum().CallCalculateSumNaive(),
                "calculate-sum-by-gauss" => new CalculateSum().CallCalculateSumByGauss(),
                "max-pairwise-product-naive" => new MaxPairwiseProduct().CallMaxPairwiseProductNaive(),
                "max-pairwise-product-fast" => new MaxPairwiseProduct().CallMaxPairwiseProductFast(),
                "calculate-fibonacci-naive" => new FibonacciNumber().CallCalculateFibonacciNaive(),
                "calculate-fibonacci-note" => new FibonacciNumber().CallCalculateFibonacciNote(),
                "calculate-fibonacci-array" => new FibonacciNumber().CallCalculateFibonacciArray(),
                "calculate-fibonacci-without-array" => new FibonacciNumber().CallCalculateFibonacciWithoutArray(),
                "calculate-fibonacci-practice" => new FibonacciNumber().CallCalculateFibonacciPractice(),
                "calculate-gcd-naive" => new GreatestCommonDivisor().CallCalculateGreatestCommonDivisorNaive(),
                "calculate-gcd-euclidean" => new GreatestCommonDivisor().CallCalculateGreatestCommonDivisorEuclidean(),
                "calculate-gcd-practice" => new GreatestCommonDivisor().CallCalculateLeastCommonMultiple(),
                
                // sorting
                "bubble-sort" => new BubbleSorter().CallBubbleSort(),
                "bubble-sort-descending" => new BubbleSorter().CallBubbleSortDescending(),
                "selection-sort" => new SelectionSorter().CallSelectionSort(),
                "selection-sort-descending" => new SelectionSorter().CallSelectionSortDescending(),
                "insertion-sort" => new InsertionSorter().CallInsertionSort(),
                "insertion-sort-descending" => new InsertionSorter().CallInsertionSortDescending(),
                "quick-sort-lomuto-partition" => new QuickSorter().CallQuickSortWithLomutoPartition(),
                "quick-sort-hoare-partition" => new QuickSorter().CallQuickSortWithHoarePartition(),
                "quick-find" => new UnitFindClient().QuickFindTest(),
                "quick-union" => new UnitFindClient().QuickUnionTest(),
                "weighted-quick-union" => new UnitFindClient().WeightedQuickUnionTest(),
                "weighted-quick-union-path-compression" => new UnitFindClient().WeightedQuickUnionPathCompressionTest(),
                "percolation" => new PercolationClient().PercolationTest(),

                _ => MissingTag(region),
            };

            #endregion
        }

        private static int MissingTag(string tag, bool region = true)
        {
            Console.WriteLine($"No code snippet configured for {(region ? "region" : "session")}: {tag}");
            return 1;
        }

    }
}