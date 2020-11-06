/*The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, such that each number is 
 * the sum of the two preceding ones, starting from 0 and 1. That is, F(0) = 0,   F(1) = 1
 * F(N) = F(N - 1) + F(N - 2), for N > 1. Given N, calculate F(N).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Easy
{
    class FibonacciNumber
    {
        public int Fib(int N)
        {
            if (N <= 1)
                return N;
            int fn0 = 0;
            int fn1 = 1;
            int fn = 0;
            int i = 1;
            while (i < N)
            {
                fn = fn1 + fn0;
                fn0 = fn1;
                fn1 = fn;
                i++;
            }
            return fn;
        }
    }
}
