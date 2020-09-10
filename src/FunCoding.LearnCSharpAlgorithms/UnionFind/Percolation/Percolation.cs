using System;

namespace FunCoding.LearnCSharpAlgorithms.UnionFind.Percolation
{
    public class Percolation : IPercolation
    {
        private readonly bool[,] _grid;
        private readonly int _gridSize;
        private int _openSites;
        private readonly int _virtualTop;
        private readonly int _virtualBottom;
        private readonly WeightedQuickUnionUf _wquGrid;
        private readonly WeightedQuickUnionUf _wquGridFull;

        public Percolation(int size)
        {
            _gridSize = size;
            _grid = new bool[size, size];
            _openSites = 0;
            var count = size * size;
            _wquGrid = new WeightedQuickUnionUf(count + 2);
            _wquGridFull = new WeightedQuickUnionUf(count + 1);
            _virtualTop = count;
            _virtualBottom = count + 1;
        }

        public void Open(int row, int col)
        {
            Validate(row, col);
            if (IsOpen(row, col))
            {
                return;
            }
            var index = FindIndex(row, col);
            _grid[row - 1, col - 1] = true;
            _openSites++;

            if (row == 1)
            {
                _wquGrid.Union(_virtualTop, index);
                _wquGridFull.Union(_virtualTop, index);
            }
            else if (row == _gridSize)
            {
                _wquGrid.Union(_virtualBottom, index);
            }

            // Check up site
            if (IsInGrid(row -1, col) && IsOpen(row -1, col))
            {
                _wquGrid.Union(index, index - _gridSize);
                _wquGridFull.Union(index, index - _gridSize);
            }
            // Check down site
            if (IsInGrid(row + 1, col) && IsOpen(row + 1, col))
            {
                _wquGrid.Union(index, index + _gridSize);
                _wquGridFull.Union(index, index + _gridSize);
            }
            // Check left site
            if (IsInGrid(row, col - 1) && IsOpen(row, col - 1))
            {
                _wquGrid.Union(index, index - 1);
                _wquGridFull.Union(index, index - 1);
            }
            // Check right site
            if (IsInGrid(row, col + 1) && IsOpen(row, col + 1))
            {
                _wquGrid.Union(index, index + 1);
                _wquGridFull.Union(index, index + 1);
            }
        }

        public bool IsOpen(int row, int col)
        {
            Validate(row, col);
            return _grid[row - 1, col - 1];
        }

        public bool IsFull(int row, int col)
        {
            return _wquGridFull.Find(_virtualTop) == _wquGridFull.Find(FindIndex(row, col));
        }

        public int NumberOfOpenSites()
        {
            return _openSites;
        }

        public bool Percolates()
        {
            return _wquGrid.Find(_virtualTop) == _wquGrid.Find(_virtualBottom);
        }

        private int FindIndex(int row, int col)
        {
            return (row - 1) * _gridSize + col - 1;
        }

        private void Validate(int row, int col)
        {
            if (!IsInGrid(row, col))
            {
                throw new ArgumentException("row index or col index is invalid");
            }
        }

        private bool IsInGrid(int row, int col)
        {
            return row > 0 && row <= _gridSize && col > 0 && col <= _gridSize;
        }
    }
}
