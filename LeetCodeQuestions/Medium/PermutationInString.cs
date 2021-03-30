//https://leetcode.com/problems/permutation-in-string/
//Given two strings s1 and s2, write a function to return true if s2 contains the permutation of s1. 
//In other words, one of the first string's permutations is the substring of the second string.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Medium
{
    class PermutationInString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            int windowStart = 0, matched = 0;
            Dictionary<char, int> charFreqMap = new Dictionary<char, int>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (!charFreqMap.ContainsKey(s1[i]))
                    charFreqMap.Add(s1[i], 1);
                else
                    charFreqMap[s1[i]]++;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                if (charFreqMap.ContainsKey(s2[i]))
                {
                    charFreqMap[s2[i]]--;
                    if (charFreqMap[s2[i]] == 0)
                        matched++;
                }

                if (matched == charFreqMap.Count)
                    return true;

                if (i >= s1.Length - 1)
                {
                    if (charFreqMap.ContainsKey(s2[windowStart]))
                    {
                        if (charFreqMap[s2[windowStart]] == 0)
                            matched--;
                        charFreqMap[s2[windowStart]]++;
                    }
                    windowStart++;
                }
            }
            return false;
        }
    }
}
