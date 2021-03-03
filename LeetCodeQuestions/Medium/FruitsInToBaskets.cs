//https://leetcode.com/problems/fruit-into-baskets/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Medium
{
    class FruitsInToBaskets
    {
        public int TotalFruit(int[] tree)
        {
            int maxCount = 0, windowStart = 0;
            Dictionary<int, int> freqMap = new Dictionary<int, int>();
           for(int i = 0; i < tree.Length; i++)
            {
                if(!freqMap.ContainsKey(tree[i]))
                {
                    freqMap.Add(tree[i], 1);
                }
                else
                {
                    freqMap[tree[i]]++;
                }

                while(freqMap.Count > 2)
                {
                    freqMap[tree[windowStart]]--;
                    if (freqMap[tree[windowStart]] == 0)
                        freqMap.Remove(tree[windowStart]);
                    windowStart++;
                }
                maxCount = Math.Max(maxCount, i - windowStart + 1);
            }
            return maxCount;
        }
    }
}
