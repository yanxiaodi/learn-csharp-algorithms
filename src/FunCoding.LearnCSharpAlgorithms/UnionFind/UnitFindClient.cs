using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding.LearnCSharpAlgorithms.UnionFind
{
    public class UnitFindClient
    {
        #region quick-find
        public int QuickFindTest()
        {
            int n = 10;
            var input = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(4, 3),
                new Tuple<int, int>(3, 8),
                new Tuple<int, int>(6, 5),
                new Tuple<int, int>(9, 4),
                new Tuple<int, int>(2, 1),
                new Tuple<int, int>(8, 9),
                new Tuple<int, int>(5, 0),
                new Tuple<int, int>(7, 2),
                new Tuple<int, int>(6, 1),
                new Tuple<int, int>(1, 0),
                new Tuple<int, int>(6, 7)
            };
            var uf = new QuickFindUf(n);
            foreach (var tuple in input)
            {
                if (!uf.Connected(tuple.Item1, tuple.Item2))
                {
                    uf.Union(tuple.Item1, tuple.Item2);
                    Console.WriteLine($"{tuple.Item1} {tuple.Item2}");
                }
            }
            Console.WriteLine($"{uf.Count()} components");
            return 0;
        }
        #endregion

        #region quick-union

        public int QuickUnionTest()
        {
            int n = 10;
            var input = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(4, 3),
                new Tuple<int, int>(3, 8),
                new Tuple<int, int>(6, 5),
                new Tuple<int, int>(9, 4),
                new Tuple<int, int>(2, 1),
                new Tuple<int, int>(8, 9),
                new Tuple<int, int>(5, 0),
                new Tuple<int, int>(7, 2),
                new Tuple<int, int>(6, 1),
                new Tuple<int, int>(1, 0),
                new Tuple<int, int>(6, 7)
            };
            var uf = new QuickUnionUf(n);
            foreach (var tuple in input)
            {
                if (!uf.Connected(tuple.Item1, tuple.Item2))
                {
                    uf.Union(tuple.Item1, tuple.Item2);
                    Console.WriteLine($"{tuple.Item1} {tuple.Item2}");
                }
            }
            Console.WriteLine($"{uf.Count()} components");
            return 0;
        }

        #endregion
    }
}
