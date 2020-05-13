# Why Data Structure and Algorithms Matter

Anyone who has written even a few lines of programs may start from a simple **Hello World** project. We learn how to input/output data and some basic structures, eg. loop, conditional, recursion, etc, and we may think “*Hey, I can write code!*” But actually, the programming is not as easy as just using `if else`, `while true` or something like that. Sometimes we need to dive deep into the underlying data, and find out the best way to solve the problems.

I create this repo to help myself go over basic data structures and algorithms. I would be very happy if it is helpful for you. I'll use C# as the main language in this repo.

First, let's see why we need to use the correct data structure.

## Array

The `array` is one of the most basic data structure. To be honest, I am used to use `List` in C# as the main object type to operate a list of data. But the `List` is also based on the *array*. *Array* is a list of data elements. I assume you already know some concepts of *array*, for example:

* Each element can be accessed by its numerical `index`.

* The `index` starts from 0.

* The array can be single-dimensional, multidimensional or jagged. The simplest type of the array is the linear array(single-dimensional).

In C#, one *array* looks like this:

```csharp
int[] array = new int[] { 1, 3, 5, 7, 9 };
```

Keep in mind that the number of the length of the array is established when the array instance is created. So we cannot change the length during the lifetime of the instance.

For more about `Array` in C#: [Array](https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-3.1)

### Reading

Let us look at *reading*. Reading from an array is the simplest operation because it only takes one step. When the array is created, the computer system can jump to any particular index in the array.

### Insertion

The next operation *insertion* is not as easy as *reading*. Because it depends on where we want to insert the new element.

* If we need to insert a new element to the end of the array and there is enough spaces, we only need **one** step.

* If we want to insert it to the beginning of the array, it would be a little bit complicated. We need to shift all current elements to the right to make room for the new element. Then put it at the beginning of the array. If the array contains *N* elements, we will need **N+1** steps.

## LinkedList

Another basic data structure in computer science is *linked list*. Both *array* and *linked list* are used to store a list of data, but the key difference is the memory allocation. The *array* consumes contiguous memory locations but for the *linked list*, the memory is not contiguous. We can assign the new memory when the data is added to it.

In C#, we can use `LinkedList<T>` type to represent a *linked list*, as shown below:

```csharp
string[] words = { "the", "fox", "jumps", "over", "the", "dog" };
LinkedList<string> sentence = new LinkedList<string>(words);
```

For more about `LinkedList<T>` in C#: [LinkedList](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=netcore-3.1)

### Reading

Each element of the *linked list* has a node that points forwards to the next element. There are some other types of *linked list* that may have double linked nodes so each node can point forward and backward. But we cannot easily find the address of the particular element by its *index*. So we have to make an iteration to find the specific element. If the element is at the end of the list, we have to use **N** steps if the list contains N elements.

### Insertion

The benefit is *insertion* is easier because we can just change the node points of the elements before and after the position where you want to insert the new element. So we just need **One** step.

So we can see when we store a series of data, we have various data structures that have different advantage/disadvantages. We need to choose the proper data structures for better performance.

## Calculate the sum

Now let us talk about the algorithm. An algorithm is a particular process for solving a problem. One example is  sorting an array. There are multiple ways to sort an array but some are faster than others. We will discuss it later. Let us start from a very simple question: how to calculate the sum of numbers from 1 to N?

We can easily write code like this (I added a stopwatch to record the time):

``` cs --region calculate-sum-naive --source-file ../../src/FunCoding.LearnCSharpAlgorithms/Warmup/CalculateSum.cs --project ../../src/FunCoding.LearnCSharpAlgorithms/FunCoding.LearnCSharpAlgorithms.csproj

```

The above code is a simple and stable program. The computer can quickly compute the result. But is it fast enough? Not really. You may know there is another solution for this question by the famous mathematician - Gauss. Here is his solution:

``` cs --region calculate-sum-by-gauss --source-file ../../src/FunCoding.LearnCSharpAlgorithms/Warmup/CalculateSum.cs --project ../../src/FunCoding.LearnCSharpAlgorithms/FunCoding.LearnCSharpAlgorithms.csproj

```

If we want to calculate the sum of 1 to 10000000, the first algorithm needs 10000000 steps. But the second one only takes one step!

That is the magic of the algorithm! You may say this is actually the magic of math. Yes, it is kind of. But for the algorithms in computer science, you do not need much background about math to get started. 

## Wrapping up

Now we can see the differences between the two data structure for storing a series of data: For *reading*, *array* is faster than *linked list*, but for *insertion*, *linked list* would be a better choice. So which one should we use? The answer is "it depends". Does our data have more *reading* or *insertion*?

Also, we know that for one question, there may be multiple solutions but the algorithm we choose can seriously affect the speed of our program.

That is why we need to consider the proper data structure and algorithms in our programs. In the next chapters, we will learn how to analyze the time complexity of competing data structure and algorithms so we can find the proper ways to solve the problems. Analyzing the number of steps that an operation takes is the one of the key things when we understand the program performance.