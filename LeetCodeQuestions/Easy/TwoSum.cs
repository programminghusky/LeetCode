/* Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Easy
{
    class TwoSum
    {
        public int[] TwoNumberSum(int[] nums, int target)
        {
            Dictionary<int, int> numHash = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int secondNum = target - nums[i];
                if (!numHash.ContainsKey(secondNum))
                {
                    if (!numHash.ContainsKey(nums[i]))
                        numHash.Add(nums[i], i);
                }
                else
                {
                    return new int[] { numHash[secondNum], i };
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
