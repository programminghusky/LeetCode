/* Given an array of n positive integers and a positive integer s, find the minimal length of a contiguous subarray
 * of which the sum ≥ s. If there isn't one, return 0 instead. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Medium
{
    class MinimumSizeSubarraySum
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            int minVal = int.MaxValue;
            int sum = 0;
            int windowStart = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                while (sum >= s)
                {
                    minVal = Math.Min(minVal, i - windowStart + 1);
                    sum -= nums[windowStart];
                    windowStart++;
                }
            }
            return minVal == int.MaxValue ? 0 : minVal;
        }
    }
}
