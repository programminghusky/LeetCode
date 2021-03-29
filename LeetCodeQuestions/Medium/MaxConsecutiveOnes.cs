//https://leetcode.com/problems/max-consecutive-ones-iii/
//Given an array A of 0s and 1s, we may change up to K values from 0 to 1.
//Return the length of the longest(contiguous) subarray that contains only 1s.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Medium
{
    class MaxConsecutiveOnes
    {
        public int LongestOnes(int[] A, int K)
        {
            int windowStart = 0, maxLength = 0, maxOnesCount = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 1)
                    maxOnesCount++;
                if (i - windowStart + 1 - maxOnesCount > K)
                {
                    if (A[windowStart] == 1)
                        maxOnesCount--;
                    windowStart++;
                }
                maxLength = Math.Max(i - windowStart + 1, maxLength);
            }
            return maxLength;
        }
    }
}
