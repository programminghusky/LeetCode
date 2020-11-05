/* Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]) Return the running sum of nums.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Easy
{
    class RunningSumOf1DArray
    {
        public int[] RunningSum(int[] nums)
        {
            for(int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }
            return nums;
        }
    }
}
