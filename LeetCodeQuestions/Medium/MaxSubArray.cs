//Given an array nums and a target value k, find the maximum length of a subarray that sums to k. 
//If there isn't one, return 0 instead.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Medium
{
    class SubArray
    {
        public int MaxSubArrayLen(int[] nums, int k)
        {
            int length = int.MinValue;
            int sum = 0;
            int windowStart = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum == k)
                {
                    length = Math.Max(length, i - windowStart + 1);
                    sum -= nums[windowStart];
                    windowStart++;
                }
                else if(sum > k)
                {
                    sum -= nums[windowStart];
                    windowStart++;
                }
            }
            return length == int.MinValue ? 0 : length;
        }
    }
}
