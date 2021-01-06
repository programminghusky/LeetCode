/* Given an array consisting of n integers, find the contiguous subarray of given length k that has the maximum average value. 
 * And you need to output the maximum average value.  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Easy
{
    class MaximumAverageSubarrayI
    {
        public double FindMaxAverage(int[] nums, int k)
        {

            double maxAvg = int.MinValue;
            double windowSum = 0;
            int windowStart = 0;
            for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
            {
                windowSum += nums[windowEnd];
                if (windowEnd >= k - 1)
                {
                    double avg = windowSum / k;
                    maxAvg = Math.Max(avg, maxAvg);
                    windowSum -= nums[windowStart];
                    windowStart++;
                }
            }
            return maxAvg;
        }
    }
}
