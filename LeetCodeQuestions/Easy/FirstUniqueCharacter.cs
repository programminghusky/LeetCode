/* Given a string, find the first non-repeating character in it and return its index. If it doesn't exist, return -1. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Easy
{
    class FirstUniqueCharacter
    {
        public int FirstUniqeChar(string s)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!hash.ContainsKey(s[i]))
                {
                    //add it
                    hash.Add(s[i], 1);
                }
                else
                {
                    hash[s[i]]++;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (hash[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
