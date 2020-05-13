# What is Big O Notation

We have seen that for one problem, there are multiple algorithms. Butwhich one is faster? We need to have a way to indicate the effeciency of the algorithm. Computer scientists borrowed a concept from mathematics to describe the efficiency of the data structures and algorithms - *Big O Notation*. So we can use the same languge to talk about the time complexity.

## How to count the steps

Let us see the previous examples to calculate the sum of numbers from 1 to N:

Algorithm 1:

``` cs --region calculate-sum-naive --source-file ../../src/FunCoding.LearnCSharpAlgorithms/Warmup/CalculateSum.cs --project ../../src/FunCoding.LearnCSharpAlgorithms/FunCoding.LearnCSharpAlgorithms.csproj

```

Algorithm 2:

``` cs --region calculate-sum-by-gauss --source-file ../../src/FunCoding.LearnCSharpAlgorithms/Warmup/CalculateSum.cs --project ../../src/FunCoding.LearnCSharpAlgorithms/FunCoding.LearnCSharpAlgorithms.csproj

```

For algorithm 1, it makes a loop, which will take N steps. For algorithm 2, it takes one step. Obviously, there are some other operations like assignments, but it doesn't matter. So we can say, the time complexity of algorithm 1 is **O(N)**, for algorithm 2, it is **O(1)**. You would see the second algorithm is much faster than the first one.

Let us see another example.

> Question: Maximum Pairwise Product Problem
>
> Find the maximum product of two distinct numbers in a sequence of non-negative integers. 
>
> Input: A sequence of non-negative integers, eg. a<sub>1</sub>, a<sub>2</sub>.....a<sub>n</sub>.
>
> Output: The maximum value that can be obtained by multiplying two different elements from the sequence
>
> Note that i and j should be different, though it may be the case that a<sub>i</sub> = a<sub>j</sub>
>
> Constraints. 2 ≤ n ≤ 2 · 10<sup>5</sup>; 0 ≤ a<sub>1</sub>...a<sub>n</sub> ≤ 2 * 10<sup>5</sup>

The naive algorithm is to make a nested loop:

``` cs --region max-pairwise-product-naive --source-file ../../src/FunCoding.LearnCSharpAlgorithms/Warmup/MaxPairwiseProduct.cs --project ../../src/FunCoding.LearnCSharpAlgorithms/FunCoding.LearnCSharpAlgorithms.csproj

```

That means if we have an array that contains 1000 elements, we need 1000 * 1000 steps!

Another algorithm is we find the first two big numbers in the array, then get the product of them:

``` cs --region max-pairwise-product-fast --source-file ../../src/FunCoding.LearnCSharpAlgorithms/Warmup/MaxPairwiseProduct.cs --project ../../src/FunCoding.LearnCSharpAlgorithms/FunCoding.LearnCSharpAlgorithms.csproj

```

This algorithm is better because we only have two iterations, which has 1000 + 1000 steps.

## Is O(2N) equal to O(N)?

The complexity of the first algorithm is **O(N<sup>2</sup>)** and for the second one, it is **O(2N)**. But actually, we only need to consider the highest exponent. To prove this, let us say we have these algorithms: algorithm A is O(2N<sup>2</sup>), algorithm B is O(3N+1), algorithm C is O(2N<sup>2</sup>+3N+1). I got this example from this book: https://book.douban.com/subject/6424904/. Let us see the below table:

| Times     | Algorithm A(O(2N<sup>2</sup>)) | Algorithm B(O(3N+1)) | Algorithm C(O(2N<sup>2</sup>+3N+1)) |
| --------- | ------------------------------ | -------------------- | ----------------------------------- |
| n=1       | 2                              | 4                    | 6                                   |
| n=2       | 8                              | 7                    | 15                                  |
| n=5       | 50                             | 16                   | 66                                  |
| n=10      | 200                            | 31                   | 231                                 |
| n=100     | 20000                          | 301                  | 20301                               |
| n=1000    | 2000000                        | 3001                 | 2003001                             |
| n=10000   | 200000000                      | 30001                | 200030001                           |
| n=100000  | 20000000000                    | 300001               | 20000300001                         |
| n=1000000 | 2000000000000                  | 3000001              | 2000003000001                       |

So we can see the constants can be ignored as N grows. For O(2N), actually it has the same time complexity with O(N).

## Best-case and Worst-case

Even for a same algorithm, we may get various result when we run it multiple times. For example, if we want to search an element in an array, we need to use an iteration to search it one by one. If the element is at the first position of the array, we only need one step, which is O(1). But if it is at the last position, obviously we need N steps, which is O(N). So O(1) is the best-case scenario, but O(N) is the worst-case scenario. However, in the real life, we use Big O Notation to refer the worst-case scenario unless specified otherwise. Because we are not so lucky to always have the best-case scenario so it is kind of pessimistic approach. If we are ready for the worst-case scenario, we could be easily handle all the situations.



## Wrapping up

The best time complexity is O(1). We also know some other time complexities such as O(N) and O(N<sup>2</sup>). We may meet some others like O(logN), O(2<sup>N</sup>), etc. When we write our code, we should only use some of them, such as O(1), O(N), O(logN), etc. For O(N<sup>3</sup>) or O(N!) or O(2<sup>N</sup>), we should never use them because they would be the nightmares if N is a big number - the computer may not complete the calculation until several hundred years pass!

Here is a comparison of some time complexities:

>  O(1) < O(logN) < O(N) < O(NlogN) < O(N<sup>2</sup>) < O(N<sup>3</sup>) < O(2<sup>N</sup>) < O(N!) < O(N<sup>N</sup>)

[Return to README](../../README.md)