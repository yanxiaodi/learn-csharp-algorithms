using System;

namespace FunCoding.LearnCSharpAlgorithms.UnionFind
{
    #region quick-find

    /// <summary>
    /// Java version: https://algs4.cs.princeton.edu/15uf/QuickFindUF.java.html
    /// </summary>
    /// <seealso cref="FunCoding.LearnCSharpAlgorithms.UnionFind.IUnionFind" />
    public class QuickFindUf : IUnionFind
    {
        private readonly int[] _id;
        /// <summary>
        /// The number of components
        /// </summary>
        private int _count;
        public QuickFindUf(int n)
        {
            _id = new int[n];
            // Set id of each object to itself. N array accesses
            for (int i = 0; i < n; i++)
            {
                _id[i] = i;
            }

            _count = n;
        }

        public void Union(int p, int q)
        {
            Validate(p);
            Validate(q);
            int pid = _id[p];
            int qid = _id[q];
            //Change all entries with id[p] to id[q] (at most 2N+2 array accesses)
            for (int i = 0; i < _id.Length; i++)
            {
                if (_id[i] == pid)
                {
                    _id[i] = qid;
                }
            }

            _count--;
        }

        public bool Connected(int p, int q)
        {
            Validate(p);
            Validate(q);
            //Check whether p and q are in the same component. 2 array accesses.
            return _id[p] == _id[q];
        }

        public int Find(int p)
        {
            Validate(p);
            // 1 array access.
            return _id[p];
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
        #endregion

    }
}
