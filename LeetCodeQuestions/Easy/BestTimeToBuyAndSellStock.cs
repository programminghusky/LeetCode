/* Say you have an array for which the ith element is the price of a given stock on day i. If you were only permitted
 * to complete at most one transaction (i.e., buy one and sell one share of the stock), design an algorithm to find the
 * maximum profit. Note that you cannot sell a stock before you buy one. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Easy
{
    class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int minPrice = int.MaxValue;
            for(int i = 0; i < prices.Length; i++)
            {
                minPrice = Math.Min(prices[i], minPrice);
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            }
            return maxProfit;
    }
    }
}
