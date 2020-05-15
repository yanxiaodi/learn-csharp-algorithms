# Selection Sort

**Selection Sort** is an in-place comparison sorting algorithm. FYI: https://en.wikipedia.org/wiki/Selection_sort

The steps of Selection Sort are shown as below:

1. Check each item from lefe to right to find out which one is least. Keep a variable to track its index. If we encounter a item that is less than the one in the index variable(its value), we replace the index variable to make sure it points to the new index.
2. Once we complete the passthrough, we swap the index with the value we began the passthrough with.
3. Repeat steps 1 and 2 until all the items are sorted.

Let us see an example. Assume that we have an array [5, 3, 4, 2, 1]. Let us begin passthrough 1:

* [5, 3, 4, 2, 1]
* First, we start from the first item 5. We create a variable to record its index, which is 0 at the moment. Compare it with 3. 3 is less than 5, so we update index as 1, which is the index of 3.
* Compare 3 with 4. 3 is less than 4, so no need to update the index.
* Compare 3 with 2. 2 is less than 3, so we update index as 3, which is the index of 2.
* Compare 2 with 1. 1 is less than 2, so we update index as 4, which is the index of 1.
* Because we start from array<sub>0</sub>, and array<sub>4</sub> is the lowest value, we swap them. So array<sub>0</sub> now is the lowest value: [1, 3, 4, 2, 5]

Next start passthrough 2:

* The first item array<sub>0</sub> already is the lowest value. So we start from array<sub>1</sub>, which is 3. The index variable is 1 now.
* Compare 3 and 4. 3 is less than 4, so no need to update the index.
* Compare 3 and 2. 2 is less than 3, so we update the index to 3, which is the index of 2.
* Compare 2 and 5. No need to update.
* This time array<sub>3</sub> is the lowest value, so we swap array<sub>3</sub> and array<sub>1</sub> because this time we start from array<sub>1</sub>: [1, 2, 4, 3, 5].

Repeat until we got the final result.

## Selection Sort Implementation

Here is the implementation of Selection Sort:

``` cs --region selection-sort --source-file ../../src/FunCoding.LearnCSharpAlgorithms/Sorting/SelectionSorter.cs --project ../../src/FunCoding.LearnCSharpAlgorithms/FunCoding.LearnCSharpAlgorithms.csproj

```

Selection Sort by descending:

``` cs --region selection-sort-descending --source-file ../../src/FunCoding.LearnCSharpAlgorithms/Sorting/SelectionSorter.cs --project ../../src/FunCoding.LearnCSharpAlgorithms/FunCoding.LearnCSharpAlgorithms.csproj

```

## Time complexity of Selection Sort

Like Bubble Sort, Selection Sort also has two type of steps: comparisons and swaps. But Selection Sort is faster than Bubble Sort. Because it won't swap the items for each comparison. More accurately, it only swaps once in each passthrough for the worst scenario.

Assume we have N items in the array, we have known that we need (N-1) +(N-2) + (N-3)... + 1 comparisons. But even for the worst scenarios, we make one swap for each passthrough. So **Selection Sort is twice as fast as Bubble Sort**.

However, Selection Sort and Bubble Sort have the same time complexity: O(N<sup>2</sup>). Because **Big O Notation ignores constants**. So O(N<sup>2</sup>/2) is equal to O(N<sup>2</sup>).

Does it mean Big O Notation is useless? No. Big O Notation provides a very important way to estimate the long-term growth rate of algorithms. You could find more here: https://en.wikipedia.org/wiki/Big_O_notation.

[Return to README](../../README.md)