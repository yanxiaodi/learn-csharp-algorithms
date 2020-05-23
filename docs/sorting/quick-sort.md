# Quick Sort

**Quick Sort** is an efficient sorting algorithm. For average scenarios, it is faster than **Insertion Sort** and **Selection Sort**. But for worst-case scenarios(eg. inversely sorted arrays), it performs similary to them. FYI: https://en.wikipedia.org/wiki/Quicksort.

Quick Sort relies on a concept called *partitioning*. The steps are as follows:

1. Take a random value from the array - which is called the **pivot**.
2. Move the items to make sure that that every number that is less than the pivot ends up to the left of the pivot, and that every number that is greater than the pivot ends up to the right of the pivot. We call these two arrays *sub-arrays*.
3. Repeate step 1 and 2 for the *sub-arrays* recursively until the array is sorted.

However, the pivot selection and partitioning steps can be done in various ways, which would affect the performance.

## Lomuto Partition

This scheme first picks a value as the pivot that is the last item in the array. Then it uses two indexes - i and j , to scan the array from the left end to the right end. Both i and j start from the left end. Then use j to iterate the items. If the item at j is less than the pivot, then swap array<sub>i</sub> and array<sub>j</sub>. At last, swap the pivot and array<sub>i</sub>. So all the items at the left side of the pivot are less than it, and all the items at the right side are greater than the pivot.

Then recursively apply the same partitioning steps for the sub-arrays.

Here is the implementation of this algorithm:

``` cs --region quick-sort-lomuto-partition --source-file ../../src/FunCoding.LearnCSharpAlgorithms/Sorting/QuickSorter.cs --project ../../src/FunCoding.LearnCSharpAlgorithms/FunCoding.LearnCSharpAlgorithms.csproj

```