using System;

namespace FunCoding.LearnCSharpAlgorithms.UnionFind
{
    #region weighted-quick-union-path-compression    
    public class WeightedQuickUnionWithPathCompressionUf : IUnionFind
    {
        private readonly int[] _id;
        /// <summary>
        /// The number of components
        /// </summary>
        private int _count;
        /// <summary>
        /// size[i] = number of elements in subtree rooted at i
        /// </summary>
        private readonly int[] _size;
        public WeightedQuickUnionWithPathCompressionUf(int n)
        {
            _id = new int[n];
            _size = new int[n];
            // Set id of each object to itself (N array accesses)
            for (int i = 0; i < n; i++)
            {
                _id[i] = i;
                _size[i] = 1;
            }

            _count = n;
        }

        public void Union(int p, int q)
        {
            var rootP = Find(p);
            var rootQ = Find(q);
            if (rootP == rootQ)
            {
                return;
            }
            // Make smaller tree point to larger one.
            if (_size[rootP] < _size[rootQ])
            {
                _id[rootP] = rootQ;
                _size[rootQ] += _size[rootP];
            }
            else
            {
                _id[rootQ] = rootP;
                _size[rootP] += _size[rootQ];
            }

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
                // Flatten the tree!
                _id[p] = _id[_id[p]];
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
