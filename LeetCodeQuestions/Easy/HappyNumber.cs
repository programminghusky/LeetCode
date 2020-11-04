/* Write an algorithm to determine if a number n is "happy". A happy number is a number defined by the following process: 
 * Starting with any positive integer, replace the number by the sum of the squares of its digits, and repeat the process
 * until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. Those numbers 
 * for which this process ends in 1 are happy numbers. Return True if n is a happy number, and False if not.  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Easy
{
    class HappyNumber
    {

        public bool IsHappy(int n)
        {
            int slow = n, fast = n;
            do
            {
                slow = FindSumSquareDigits(slow);
                fast = FindSumSquareDigits(fast);
                fast = FindSumSquareDigits(fast);
            } while (slow != fast);
            return slow == 1;
        }

        private int FindSumSquareDigits(int num)
        {
            int sum = 0;
            int digit = 0;
            while (num != 0)
            {
                digit = num % 10;
                sum = sum + (digit * digit);
                num = num / 10;
            }
            return sum;
        }
    }
}
