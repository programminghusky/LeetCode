/* Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range
 * that is missing from the array. Follow up: Could you implement a solution using only 
 * O(1) extra space complexity and O(n) runtime complexity? */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Easy
{
    class MissingNumber
    {
        public int MissingNumber1(int[] nums)
        {

            int n = nums.Length;
            int xor = 0;
            for (int i = 0; i < n; i++)
            {
                xor = xor ^ nums[i] ^ i;
            }

            return xor ^ n;
        }
    }
}
