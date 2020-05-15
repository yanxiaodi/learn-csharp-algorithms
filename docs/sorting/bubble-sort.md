# Bubble Sort

In this part, we will write some code to solve a practical problem, such as *sorting*. It is a common question in every platform or program language:

> Given an array of unsorted numbers, how can we sort them so that they end up in ascending order?

There are a bunch of sorting algorithms that have been developed over the years. Let us get started from a very basic sorting algorithm - **Bubble Sort**.

## What is Bubble Sort

This sorting algorithm is like to float bubbles to the top of the array. It follows these steps:

1. First, we start from the beginning of the array and point to its first two items.
2. Compare the first item with the second one. If the two items are out of order - in other words, the left item is greater than the right item, swap them. If they are already in the correct order, do nothing for this step. 
3. Move the pointers one cell to the right. That means, the first point is for the second item in the array, the second point is for the third one.
4. Repeat step 2 and 3 until we reach the end of the array or any items that have already been sorted.
5. Repeat step 1 through 3 until all items are sorted. That means the array is in order.

Let us see an example. Assume that we have an array [5, 3, 4, 2, 1]. Let us begin passthrough 1:

* [5, 3, 4, 2, 1]
* First, we compare 5 and 3. They are out of order, so we swap them: [3, 5, 4, 2, 1].
* Next, compare 5 and 4. They are out of order, so swap them: [3, 4, 5, 2, 1].
* Next, compare 5 and 2. Swap them: [3, 4, 2, 5, 1].
* Next, compare 5 and 1. Swap them: [3, 4, 2, 1, 5].
* Now 5 is in its correct position. In each passthrough, the biggest number bubbles up to its correct position.

Next we begin passthrough 2:

* [3, 4, 2, 1, 5]
* Compare 3 and 4. They are in the correct order, so do nothing this step.
* Compare 4 and 2. Swap them: [3, 2, 4, 1, 5]
* Compare 4 and 1. Swap them: [3, 2, 1, 4, 5]
* Because we already know 5 is in its correct position, so we can stop this passthrough.

Next passthrough 3...

Finally, we will get a sorted array: [1, 2, 3, 4, 5].

## Bubble Sort Implementation

Here is the basic bubble sort algorithm:

``` cs --region bubble-sort --source-file ../../src/FunCoding.LearnCSharpAlgorithms/Sorting/BubbleSorter.cs --project ../../src/FunCoding.LearnCSharpAlgorithms/FunCoding.LearnCSharpAlgorithms.csproj

```

## Time complexity of Bubble Sort

Let us check the efficiency of Bubble Sort. Looking back the previous section, we have 5 elements in the array. In the first passthrough, there are 4 comparisons. In the second passthrough, there are 3 comparisons. So we would say that for N elements, there are (N-1) + (N-2) + (N-3) + 1 comparisons. We also need to swap the items. For the worst scenarios, we always need to swap them. So the swap steps should be the same with comparisons. Assume that we have 5 elements, we need 10 steps for comparisons and 10 steps for swapping. Let us see the below table:

| N                 | Steps             | N<sup>2</sup>     |
| ------------------| ------------------| ------------------|
| n=5               | 20                | 25                |
| n=10              | 90                | 100               |
| n=20              | 380               | 400               |
| n=40              | 1560              | 1600              |
| n=80              | 6320              | 6400              |

We can see that the steps grows by approximately N<sup>2</sup>. So we would say the time complexity of Bubble Sort is O(N<sup>2</sup>).

As we said before, actually O(N<sup>2</sup>) is not an efficient algorithm because when N grows, the time-consuming increases rapidly. Whenever we got a slow algorithm, it is worth to spending time to think about if we can find a better solution. Especially when we are dealing with some huge data, the slow algorithm is unacceptable.

Here is the bubble sort algorithm to sort the array by descending:

``` cs --region bubble-sort-descending --source-file ../../src/FunCoding.LearnCSharpAlgorithms/Sorting/BubbleSorter.cs --project ../../src/FunCoding.LearnCSharpAlgorithms/FunCoding.LearnCSharpAlgorithms.csproj

```

[Return to README](../../README.md)