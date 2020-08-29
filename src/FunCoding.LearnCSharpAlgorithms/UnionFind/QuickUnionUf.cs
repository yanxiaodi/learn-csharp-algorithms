using System;

namespace FunCoding.LearnCSharpAlgorithms.UnionFind
{
    /// <summary>
    /// Java version: https://algs4.cs.princeton.edu/15uf/QuickUnionUF.java.html
    /// </summary>
    /// <seealso cref="FunCoding.LearnCSharpAlgorithms.UnionFind.UnionFind" />
    public class QuickUnionUf : UnionFind
    {
        public QuickUnionUf(int n) : base(n)
        {
            // Set id of each object to itself (N array accesses)
            for (int i = 0; i < n; i++)
            {
                Id[i] = i;
            }

            count = n;
        }

        public override void Union(int p, int q)
        {
            // Change the root of p to point to the root of q (depth of p and q array accesses)
            var rootP = Find(p);
            var rootQ = Find(q);
            Id[rootP] = rootQ;
            count--;
        }

        public override bool Connected(int p, int q)
        {
            // Check if p and q have the same root (depth of p and q array accesses)
            return Find(p) == Find(q);
        }

        public override int Find(int p)
        {
            Validate(p);
            // Chase parent pointers until reach root (depth of i array accesses)
            while (p != Id[p])
            {
                p = Id[p];
            }

            return p;
        }

        public override int Count()
        {
            return count;
        }

        private void Validate(int p)
        {
            var n = Id.Length;
            if (p < 0 || p >= n)
            {
                throw new ArgumentOutOfRangeException(nameof(p), $"Index {p} should be between 0 and {n}");
            }
        }
    }
}
