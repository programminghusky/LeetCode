//https://leetcode.com/problems/longest-repeating-character-replacement/
//In one operation, you can choose any character of the string and change it to any other uppercase English character.
//Find the length of the longest sub-string containing all repeating letters you can get after performing the above operations.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Medium
{
    class LongestRepeatingCharacterReplacement
    {
        public int CharacterReplacement(string s, int k)
        {
            int windowStart = 0;
            int maxLength = 0;
            int maxChars = 0;
            Dictionary<char, int> chars = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!chars.ContainsKey(s[i]))
                {
                    chars.Add(s[i], 1);
                }
                else
                {
                    chars[s[i]]++;
                }
                maxChars = Math.Max(maxChars, chars[s[i]]);
                if ((i - windowStart + 1 - maxChars) > k)
                {
                    chars[s[windowStart]]--;
                    windowStart++;
                }
                maxLength = Math.Max(i - windowStart + 1, maxLength);
            }
            return maxLength;
        }
    }
}
