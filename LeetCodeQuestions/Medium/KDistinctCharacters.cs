//Given a string s and an integer k, return the length of the longest substring of s that contains at most k distinct characters.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Medium
{
    class KDistinctCharacters
    {
        public int LengthOfLongestSubstringKDistinct(string s, int k)// bcdaabcd k = 1
        {
            int length = 0;
            int windowStart = 0;
            Dictionary<char,int> freq = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                if(!freq.ContainsKey(s[i]))
                {
                    freq.Add(s[i], 1);
                }
                else
                {
                    freq[s[i]]++;
                }
                while(freq.Count > k)
                {
                    freq[s[windowStart]]--;
                    if (freq[s[windowStart]] == 0)
                        freq.Remove(s[windowStart]);

                    windowStart++;
                }
                length = Math.Max(length, i - windowStart + 1);
            }
            return length;
        }
    }
}
