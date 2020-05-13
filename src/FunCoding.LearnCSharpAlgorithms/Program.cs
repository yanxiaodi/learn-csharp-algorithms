// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
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
                "calculate-sum-naive" => new CalculateSum().CalculateSumNaive(),
                "calculate-sum-by-gauss" => new CalculateSum().CalculateSumByGauss(),
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