/*Given an integer array nums, find the contiguous subarray (containing at least one number) 
 * which has the largest sum and return its sum. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Easy
{
    class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSoFar = nums[0], maxEndingHere = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                maxEndingHere = Math.Max(nums[i], maxEndingHere + nums[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }
            return maxSoFar;
        }
    }
}
