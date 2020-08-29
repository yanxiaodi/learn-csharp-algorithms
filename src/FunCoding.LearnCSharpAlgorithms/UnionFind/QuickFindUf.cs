using System;

namespace FunCoding.LearnCSharpAlgorithms.UnionFind
{
    /// <summary>
    /// Java version: https://algs4.cs.princeton.edu/15uf/QuickFindUF.java.html
    /// </summary>
    /// <seealso cref="FunCoding.LearnCSharpAlgorithms.UnionFind.UnionFind" />
    public class QuickFindUf : UnionFind
    {
        public QuickFindUf(int n) : base(n)
        {
            // Set id of each object to itself. N array accesses
            for (int i = 0; i < n; i++)
            {
                Id[i] = i;
            }

            count = n;
        }

        public override void Union(int p, int q)
        {
            Validate(p);
            Validate(q);
            int pid = Id[p];
            int qid = Id[q];
            //Change all entries with id[p] to id[q] (at most 2N+2 array accesses)
            for (int i = 0; i < Id.Length; i++)
            {
                if (Id[i] == pid)
                {
                    Id[i] = qid;
                }
            }

            count--;
        }

        public override bool Connected(int p, int q)
        {
            Validate(p);
            Validate(q);
            //Check whether p and q are in the same component. 2 array accesses.
            return Id[p] == Id[q];
        }

        public override int Find(int p)
        {
            Validate(p);
            // 1 array access.
            return Id[p];
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
