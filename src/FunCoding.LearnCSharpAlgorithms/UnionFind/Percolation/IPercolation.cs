namespace FunCoding.LearnCSharpAlgorithms.UnionFind.Percolation
{
    public interface IPercolation
    {
        /// <summary>
        /// Opens the site (row, col) if it is not open already
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="col">The col.</param>
        void Open(int row, int col);

        /// <summary>
        /// Determines whether the specified row is open.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="col">The col.</param>
        /// <returns>
        ///   <c>true</c> if the specified row is open; otherwise, <c>false</c>.
        /// </returns>
        bool IsOpen(int row, int col);

        /// <summary>
        /// Determines whether the specified row is full.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="col">The col.</param>
        /// <returns>
        ///   <c>true</c> if the specified row is full; otherwise, <c>false</c>.
        /// </returns>
        bool IsFull(int row, int col);

        /// <summary>
        /// Numbers the of open sites.
        /// </summary>
        /// <returns></returns>
        int NumberOfOpenSites();

        /// <summary>
        /// Does the system percolate?
        /// </summary>
        /// <returns></returns>
        bool Percolates();
    }
}
