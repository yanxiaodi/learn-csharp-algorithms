# Insertion Sort

**Insertion Sort** is another simple sorting algorithm as Bubble Sort and Selection Sort. The steps are as follows:

1. In the first passthrough, remove the value at index 1 and store it in a temporary variable. This will leave a gap at index 1.(For the subsequent passthroughs, we remove values at the subsequent indexes.)
2. Compare each value on the left of the gap to the value in the temporary variable. If the value to the left of the gap is greater than the value in the temporary variable, shift that value to the right. When we encounter a value that is lower than the value in the temporary variable or we reach the left end of the array, we stop the shifting phase.
3. Then insert the value temporary variable into the current gap.
4. Repeat steps 1 through 3 until all items are sorted.

Let us see an example. Assume that we have an array [5, 3, 4, 2, 1]. Let us begin passthrough 1:

* [5, 3, 4, 2, 1]
* First we remove array[1], which is 3. And keep it in a variable called `temp`. Now there is a gap at array[1].
* Next compare array[0] with 3. 5 is greater than 3, so we shift 5 to the right. There is nothing left to shift because we already reached the left end of the array. Now the gap is array[0].
* Next insert `temp` to the gap, which is array[0]. The first passthrough is done: [3, 5, 4, 2, 1]

Let us start passthrough 2:

* [3, 5, 4, 2, 1]
* This time we start from array[2], which is 4. Keep it in `temp`.
* Compare array[1] with `temp`. Because 5 is greater than 4, so we shift 5 to the right. Now the gap is array[1].
* Compare array[0] with `temp`. Because 3 is less than 4, so we reached a value that is less than `temp`. We can stop the shifting.
* Insert `temp` to the gap, which is array[1]. The second passthrough is done: [3, 4, 5, 2, 1].

Let us start passthrough 3:

* [3, 4, 5, 2, 1]
* This time we start from array[3], which is 2. Keep it in `temp`.
* Compare array[2] with `temp`. 5 is greater than 2, so we shift 5 to the right.
* Continue to compare array[1] with `temp`. 4 is greater than 2, so we shift 4 to the right.
* Continue to compare array[0] with `temp`. 3 is greater than 2, so we shift 3 to the right. Now the gap is array[0]. We reached the left end of the array.
* Insert `temp` to the gap, which is array[0]. The third passthrough is done: [2, 3, 4, 5, 1].

Repeat the passthroughs until we get the correct sorted array.

Here is the animation of Insertion Sort:

![img](assets/Insertion-sort-example-300px.gif)

## Insertion Sort Implementation

Here is the implementation of Insertion Sort:

``` cs --region insertion-sort --source-file ../../src/FunCoding.LearnCSharpAlgorithms/Sorting/InsertionSorter.cs --project ../../src/FunCoding.LearnCSharpAlgorithms/FunCoding.LearnCSharpAlgorithms.csproj

```

Insertion Sort by descending:

``` cs --region insertion-sort-descending --source-file ../../src/FunCoding.LearnCSharpAlgorithms/Sorting/InsertionSorter.cs --project ../../src/FunCoding.LearnCSharpAlgorithms/FunCoding.LearnCSharpAlgorithms.csproj

```

## Time complexity of Insertion Sort

Let us consider the worst scenario for this sorting algorithm. Assume we have a array that is sorted in reverse order, we have to compare every number and shift them. So we got (1+2+3+...+N) x 2 steps. Also we need to remove & insert the value for each passthrough. So the count of the total steps is about  (1+2+3+...+N) x 2 + 2N, which is approximately N<sup>2</sup>.

Because we know Big O Notation only consider the highest order of N, so we can say the time complexity of Insertion Sort is O(N<sup>2</sup>).

It looks like that Insertion Sort is almost the same with Bubble Sort. Yes it is. In the worst-case scenario, Selection Sort is faster than Bubble Sort and Insertion Sort. But for the best-case scenario, such as an array that is already sorted, we only need to have one comparison for each passthrough without any shift, because all values are already in its correct place. So the performance of Insertion Sort varies based on the scenario. Here is a table to compare the time complexities for these three sorting algorithms:

|                | Best-case scenario | Average-case scenario | Worst-case scenario |
| -------------- | ------------------ | --------------------- | ------------------- |
| Bubble Sort    | O(N)               | O(N<sup>2</sup>)      | O(N<sup>2</sup>)    |
| Selection Sort | O(N<sup>2</sup>)   | O(N<sup>2</sup>)      | O(N<sup>2</sup>)    |
| Insertion Sort | O(N)               | O(N<sup>2</sup>)      | O(N<sup>2</sup>)    |

So where should we select the proper algorithm? The answer is: it depends. If we already know the array that has been mostly sorted, Insertion Sort would be faster. If it is an average case, they have the similar performance.

[Return to README](../../README.md)