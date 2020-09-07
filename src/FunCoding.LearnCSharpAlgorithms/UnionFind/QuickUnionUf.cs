using System;

namespace FunCoding.LearnCSharpAlgorithms.UnionFind
{
    #region quick-union

    /// <summary>
    /// Java version: https://algs4.cs.princeton.edu/15uf/QuickUnionUF.java.html
    /// </summary>
    /// <seealso cref="FunCoding.LearnCSharpAlgorithms.UnionFind.IUnionFind" />
    public class QuickUnionUf : IUnionFind
    {
        private readonly int[] _id;
        /// <summary>
        /// The number of components
        /// </summary>
        private int _count;
        public QuickUnionUf(int n)
        {
            _id = new int[n];
            // Set id of each object to itself (N array accesses)
            for (int i = 0; i < n; i++)
            {
                _id[i] = i;
            }

            _count = n;
        }

        public void Union(int p, int q)
        {
            // Change the root of p to point to the root of q (depth of p and q array accesses)
            var rootP = Find(p);
            var rootQ = Find(q);
            _id[rootP] = rootQ;
            _count--;
        }

        public bool Connected(int p, int q)
        {
            // Check if p and q have the same root (depth of p and q array accesses)
            return Find(p) == Find(q);
        }

        public int Find(int p)
        {
            Validate(p);
            // Chase parent pointers until reach root (depth of i array accesses)
            while (p != _id[p])
            {
                p = _id[p];
            }

            return p;
        }

        public int Count()
        {
            return _count;
        }

        private void Validate(int p)
        {
            var n = _id.Length;
            if (p < 0 || p >= n)
            {
                throw new ArgumentOutOfRangeException(nameof(p), $"Index {p} should be between 0 and {n}");
            }
        }
    }
    #endregion

}
