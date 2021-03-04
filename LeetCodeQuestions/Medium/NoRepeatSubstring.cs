//Given a string s, find the length of the longest substring without repeating characters.
//https://leetcode.com/problems/longest-substring-without-repeating-characters/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Medium
{
    class NoRepeatSubstring
    {
        public int LengthOfLongestSubstring(string s)//abbcd// a b in hashset
        {
            int maxLength = 0, windowStart = 0;
            HashSet<char> freqSet = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {

                if (!freqSet.Contains(s[i]))
                    freqSet.Add(s[i]);
                else
                {
                    //do untill removed
                    while(freqSet.Contains(s[i]))
                    {
                        freqSet.Remove(s[windowStart]);
                        windowStart++;
                    }
                    freqSet.Add(s[i]);
                }
                 maxLength = Math.Max(maxLength, i - windowStart + 1);
            }
            return maxLength;
        }
    }
}
