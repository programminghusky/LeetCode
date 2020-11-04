/* Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Easy
{
    class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            if (s.Length < 2)
                return true;
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                    continue;
                }
                else if (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                    continue;
                }
                else if (char.ToLower(s[left]) == char.ToLower(s[right]))
                {
                    left++;
                    right--;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
