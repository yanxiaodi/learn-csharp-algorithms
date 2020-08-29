namespace FunCoding.LearnCSharpAlgorithms.UnionFind
{
    public abstract class UnionFind
    {
        protected int[] Id;
        protected int count;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnionFind"/> class with n objects (0 to n -1).
        /// </summary>
        /// <param name="n">The n.</param>
        protected UnionFind(int n)
        {
            Id = new int[n];
        }

        /// <summary>
        /// Add connection between p and q
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="q">The q.</param>
        public abstract void Union(int p, int q);

        /// <summary>
        /// Are p and q in the same component?
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="q">The q.</param>
        /// <returns></returns>
        public abstract bool Connected(int p, int q);

        /// <summary>
        /// Component identifier for p (0 to n - 1)
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        public abstract int Find(int p);

        /// <summary>
        /// Number of components
        /// </summary>
        /// <returns></returns>
        public abstract int Count();
    }
}
