# Greatest Common Divisor

The greatest common divisor GCD(𝑎, 𝑏) of two non-negative integers 𝑎 and 𝑏 (which are not both equal to 0) is the greatest integer 𝑑 that divides both 𝑎 and 𝑏. Your goal in this problem is to implement the Euclidean algorithm for computing the greatest common divisor.

Efficient algorithm for computing the greatest common divisor is an important basic primitive of commonly used cryptographic algorithms like RSA.

> Task. Given two integers 𝑎 and 𝑏, find their greatest common divisor.
>
> Input Format. The two integers 𝑎, 𝑏.
>
> Constraints. 1 ≤ 𝑎, 𝑏 ≤ 2 * 10<sup>9</sup>.
>
> Output Format. Output GCD(𝑎, 𝑏).
>
> Sample 1. Input: 18 35. Output: 1
> 18 and 35 do not have common non-trivial divisors.
>
> Sample 2. Input: 28851538 1183019. Output: 17657
> 28851538 = 17657 * 1634, 1183019 = 17657 * 67

For this question, we can easily assume that d is between 1 and a+b. So we can make an iteration from 1 to a+b, and test each number if it can divide both a and b. The method is like this:

``` cs --region calculate-gcd-naive --source-file ../../src/FunCoding.LearnCSharpAlgorithms/Warmup/GreatestCommonDivisor.cs --project ../../src/FunCoding.LearnCSharpAlgorithms/FunCoding.LearnCSharpAlgorithms.csproj

```

It works, but it is very slow when we calculate it for two big numbers. Because it needs a+b steps. It is not acceptable when we have two huge numbers.

To solve it efficiently, we can use the Euclidean Algorithm, which is an efficient method for computing the [greatest common divisor](https://en.wikipedia.org/wiki/Greatest_common_divisor) (GCD) of two integers (numbers). FYI: https://en.wikipedia.org/wiki/Euclidean_algorithm. Basically, the lemma of it is:

> Let a′ be the remainder when a is divided by b, then gcd(a, b) = gcd(a′, b) = gcd(b, a′). 

So we can write a recursion program like this:

``` cs --region calculate-gcd-euclidean --source-file ../../src/FunCoding.LearnCSharpAlgorithms/Warmup/GreatestCommonDivisor.cs --project ../../src/FunCoding.LearnCSharpAlgorithms/FunCoding.LearnCSharpAlgorithms.csproj

```

You would find this algorithm is much faster. Each step reduces the size of numbers by about a factor of 2. So it takes about log(ab) steps. If we use this algorithm for two 100 digits numbers, it takes about 600 steps.  

This example is somehow related to the math. I just want to show you the correct algorithm is much better but we need to know something about the problem. 

