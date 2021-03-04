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
            //int maxLength = 0, windowStart = 0;
            //HashSet<char> freqSet = new HashSet<char>();
            //for (int i = 0; i < s.Length; i++)
            //{

            //    if (!freqSet.Contains(s[i]))
            //        freqSet.Add(s[i]);
            //    else
            //    {
            //        //do untill removed
            //        while(freqSet.Contains(s[i]))
            //        {
            //            freqSet.Remove(s[windowStart]);
            //            windowStart++;
            //        }
            //        freqSet.Add(s[i]);
            //    }
            //     maxLength = Math.Max(maxLength, i - windowStart + 1);
            //}
            //return maxLength;

            int maxLength = 0, windowStart = 0;
            Dictionary<char,int> freqMap = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!freqMap.ContainsKey(s[i]))
                {
                    freqMap.Add(s[i], i);
                }
                else
                {
                    windowStart = Math.Max(windowStart, freqMap[s[i]] + 1);
                    freqMap[s[i]] = i; 
                }
                maxLength = Math.Max(maxLength, i - windowStart + 1);
            }

            return maxLength;
        }
    }
}
