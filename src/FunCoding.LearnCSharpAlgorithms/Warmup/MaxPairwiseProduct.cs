using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding.LearnCSharpAlgorithms.Warmup
{
    public class MaxPairwiseProduct
    {
        #region max-pairwise-product-naive
        public int CallMaxPairwiseProductNaive()
        {
            int[] array = {7, 5, 14, 2, 8, 8, 10, 1, 2, 3};
            var product = MaxPairwiseProductNaive(array);
            Console.WriteLine($"The max pairwise product is {product}");
            return 0;
        }

        public long MaxPairwiseProductNaive(int[] array)
        {
            long product = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j)
                    {
                        product = Math.Max(product, array[i] * array[j]);
                    }
                }
            }
            return product;
        }

        #endregion

        #region max-pairwise-product-fast
        public int CallMaxPairwiseProductFast()
        {
            int[] array = { 7, 5, 14, 2, 8, 8, 10, 1, 2, 3 };
            var product = MaxPairwiseProductFast(array);
            Console.WriteLine($"The max pairwise product is {product}");
            return 0;
        }

        public long MaxPairwiseProductFast(int[] array)
        {
            int index1 = 0;
            int index2 = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[index1])
                {
                    index1 = i;
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[index2] && i != index1)
                {
                    index2 = i;
                }
            }

            return array[index1] * array[index2];
        }

        #endregion

    }
}
