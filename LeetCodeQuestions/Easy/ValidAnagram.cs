/* Given two strings s and t , write a function to determine if t is an anagram of s. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Easy
{
    class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            int[] intArray = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                intArray[s[i] - 'a']++;
            }

            for (int i = 0; i < t.Length; i++)
            {
                intArray[t[i] - 'a']--;
            }
            for (int i = 0; i < 26; i++)
            {
                if (intArray[i] != 0)
                    return false;
            }
            return true;
        }
    }
}
