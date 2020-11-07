/* Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Easy
{
    class SingleNumber
    {
        public int SingleNumber1(int[] nums)
        {
            int xor = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                xor = xor ^ nums[i];
            }
            return xor;
        }
    }
}
