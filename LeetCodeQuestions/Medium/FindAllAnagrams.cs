//https://leetcode.com/problems/find-all-anagrams-in-a-string/
//Given a string s and a non-empty string p, find all the start indices of p's anagrams in s.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Medium
{
    class FindAllAnagrams
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            int windowStart = 0, matched = 0;
            List<int> indices = new List<int>();
            Dictionary<char, int> charFreqMap = new Dictionary<char, int>();
            for (int i = 0; i < p.Length; i++)
            {
                if (!charFreqMap.ContainsKey(p[i]))
                    charFreqMap.Add(p[i], 1);
                else
                    charFreqMap[p[i]]++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charFreqMap.ContainsKey(s[i]))
                {
                    charFreqMap[s[i]]--;
                    if (charFreqMap[s[i]] == 0)
                        matched++;
                }

                if (matched == charFreqMap.Count)
                    indices.Add(windowStart);

                if (i >= p.Length -1)
                {
                    if (charFreqMap.ContainsKey(s[windowStart]))
                    {
                        if (charFreqMap[s[windowStart]] == 0)
                            matched--;
                        charFreqMap[s[windowStart]]++;
                    }
                    windowStart++;
                }
            }
            return indices;
        }
    }
}
