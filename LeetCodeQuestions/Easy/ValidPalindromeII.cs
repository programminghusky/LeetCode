/*Given a non-empty string s, you may delete at most one character. Judge whether you can make it a palindrome. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Easy
{
    class ValidPalindromeII
    {
        public bool ValidPalindrome(string s)
        {
            int start = 0, end = s.Length - 1;
            while (start <= end)
            {
                if (s[start] == s[end])
                {
                    start++;
                    end--;
                }
                else
                {
                    return IsPalindrome(s, start, end - 1) ||
                         IsPalindrome(s, start + 1, end);
                }

            }
            return true;
        }

        public bool IsPalindrome(string s, int start, int end)
        {
            while (start <= end)
            {
                if (s[start] == s[end])
                {
                    start++;
                    end--;
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
