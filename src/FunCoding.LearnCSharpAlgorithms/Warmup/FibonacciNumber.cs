using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FunCoding.LearnCSharpAlgorithms.Warmup
{
    public class FibonacciNumber
    {
        #region calculate-fibonacci-naive
        public int CallCalculateFibonacciNaive()
        {
            // Create a Stopwatch to record the time.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            // You could change the below n
            int n = 35;
            Console.WriteLine(CalculateFibonacciNaive(n));
            sw.Stop();
            Console.WriteLine($"It runs {sw.ElapsedMilliseconds} milliseconds");
            return 0;
        }

        public int CalculateFibonacciNaive(int n)
        {
            if (n < 0 || n > 45)
            {
                throw new ArgumentException($"{nameof(n)} should not be greater than 45", nameof(n));
            }
            if (n <= 1)
            {
                // We must have a condition to stop the recursion.
                return n;
            }
            return CalculateFibonacciNaive(n - 1) + CalculateFibonacciNaive(n - 2);
        }
        #endregion

        #region calculate-fibonacci-note
        public int CallCalculateFibonacciNote()
        {
            // Create a Stopwatch to record the time.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            // You could change the below n
            int n = 35;
            // Create a note to record the results.
            Dictionary<int, int> note = new Dictionary<int, int>();
            Console.WriteLine(CalculateFibonacciNote(n, note));
            sw.Stop();
            Console.WriteLine($"It runs {sw.ElapsedMilliseconds} milliseconds");
            return 0;
        }

        public int CalculateFibonacciNote(int n, Dictionary<int, int> note)
        {
            if (n < 0 || n > 45)
            {
                throw new ArgumentException($"{nameof(n)} should not be greater than 45", nameof(n));
            }
            if (n <= 1)
            {
                // We must have a condition to stop the recursion.
                return n;
            }
            // If the note contains the result, just return.
            if (note.ContainsKey(n))
            {
                return note[n];
            }
            // Otherwise, add the value to the note.
            note.Add(n, CalculateFibonacciNote(n - 1, note) + CalculateFibonacciNote(n - 2, note));
            return note[n];
        }
        #endregion

        #region calculate-fibonacci-array
        public int CallCalculateFibonacciArray()
        {
            // Create a Stopwatch to record the time.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            // You could change the below n
            int n = 35;
            Console.WriteLine(CalculateFibonacciArray(n));
            sw.Stop();
            Console.WriteLine($"It runs {sw.ElapsedMilliseconds} milliseconds");
            return 0;
        }

        public int CalculateFibonacciArray(int n)
        {
            if (n < 0 || n > 45)
            {
                throw new ArgumentException($"{nameof(n)} should not be greater than 45", nameof(n));
            }
            if (n <= 1)
            {
                return n;
            }
            // Create an array to store the numbers
            int [] array = new int[n + 1];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            return array[n];
        }
        #endregion


        #region calculate-fibonacci-without-array
        public int CallCalculateFibonacciWithoutArray()
        {
            // Create a Stopwatch to record the time.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            // You could change the below n
            int n = 35;
            Console.WriteLine(CalculateFibonacciWithoutArray(n));
            sw.Stop();
            Console.WriteLine($"It runs {sw.ElapsedMilliseconds} milliseconds");
            return 0;
        }

        public int CalculateFibonacciWithoutArray(int n)
        {
            if (n < 0 || n > 45)
            {
                throw new ArgumentException($"{nameof(n)} should not be greater than 45", nameof(n));
            }
            if (n <= 1)
            {
                return n;
            }
            int previous = 0;
            int current = 1;
            int sum = 0;
            for (int i = 2; i <= n; i++)
            {
                sum = previous + current;
                previous = current;
                current = sum;
            }
            return sum;
        }
        #endregion

        #region calculate-fibonacci-practice

        public int CallCalculateFibonacciPractice()
        {
            // You could change the below n
            int n = 35;
            Console.WriteLine(CalculateFibonacciPractice(n));
            return 0;
        }
        public int CalculateFibonacciPractice(int n)
        {
            // You could implement your algorithm here
            return 0;
        }
        #endregion
    }
}
