namespace FunCoding.LearnCSharpAlgorithms.UnionFind
{
    public interface IUnionFind
    {
        //protected int[] Id;
        ///// <summary>
        ///// The number of components
        ///// </summary>
        //protected int count;

        /// <summary>
        /// Add connection between p and q
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="q">The q.</param>
        public void Union(int p, int q);

        /// <summary>
        /// Are p and q in the same component?
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="q">The q.</param>
        /// <returns></returns>
        public bool Connected(int p, int q);

        /// <summary>
        /// Component identifier for p (0 to n - 1)
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        public int Find(int p);

        /// <summary>
        /// Number of components
        /// </summary>
        /// <returns></returns>
        public int Count();
    }
}
