using System;

namespace FunCoding.LearnCSharpAlgorithms.UnionFind
{
    #region weighted-quick-union-path-compression    
    public class WeightedQuickUnionWithPathCompressionUf : UnionFind
    {
        /// <summary>
        /// size[i] = number of elements in subtree rooted at i
        /// </summary>
        private int[] size;
        public WeightedQuickUnionWithPathCompressionUf(int n) : base(n)
        {
            size = new int[n];
            // Set id of each object to itself (N array accesses)
            for (int i = 0; i < n; i++)
            {
                Id[i] = i;
                size[i] = 1;
            }

            count = n;
        }

        public override void Union(int p, int q)
        {
            var rootP = Find(p);
            var rootQ = Find(q);
            if (rootP == rootQ)
            {
                return;
            }
            // Make smaller tree point to larger one.
            if (size[rootP] < size[rootQ])
            {
                Id[rootP] = rootQ;
                size[rootQ] += size[rootP];
            }
            else
            {
                Id[rootQ] = rootP;
                size[rootP] += size[rootQ];
            }

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
                // Flatten the tree!
                Id[p] = Id[Id[p]];
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
    #endregion
}
