using System;

namespace FunCoding.LearnCSharpAlgorithms.UnionFind.Percolation
{
    public class PercolationClient
    {
        #region percolation

        public int PercolationTest()
        {
            // Please do not set the size as a big number that is greater than 500
            // otherwise it is sluggish to run in your browser.
            var size = 10;
            var percolation = new Percolation(size);
            var random = new Random(DateTime.Now.Millisecond);
            var percolated = false;
            while (!percolated)
            {
                var row = random.Next(1, size + 1);
                var col = random.Next(1, size + 1);
                Console.WriteLine($"Open row {row}, col {col}");
                percolation.Open(row, col);
                if (percolation.Percolates())
                {
                    percolated = true;
                    Console.WriteLine($"The system percolates.");
                    Console.WriteLine(
                        $"It has {percolation.NumberOfOpenSites()} open sites. Percentage: {percolation.NumberOfOpenSites() * 100 / (size * size)}%");
                }
            }

            return 0;
        }

        #endregion
    }
}
