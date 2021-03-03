//Given a string s , find the length of the longest substring t  that contains at most 2 distinct characters.
//https://leetcode.com/problems/longest-substring-with-at-most-two-distinct-characters/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Medium
{
    class _2DistinctCharacters
    {
        public int LengthOfLongestSubstringTwoDistinct(string s)
        {
            if (s == null)
                throw new Exception();

            int maxLength = 0, windowStart = 0;
            Dictionary<char, int> freqMap = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                if (!freqMap.ContainsKey(s[i]))
                {
                    freqMap.Add(s[i], 1);
                }
                else
                {
                    freqMap[s[i]]++;
                }

                while (freqMap.Count > 2)
                {
                    freqMap[s[windowStart]]--;
                    if (freqMap[s[windowStart]] == 0)
                        freqMap.Remove(s[windowStart]);
                    windowStart++;
                }
                maxLength = Math.Max(maxLength, i - windowStart + 1);
            }
            return maxLength;
        }
    }
}
