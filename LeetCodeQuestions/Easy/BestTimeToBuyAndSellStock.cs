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
            for(int i = 1; i < prices.Length; i++)
            {
                if(prices[i] > prices[i-1])
                {
                    maxProfit += (prices[i] - prices[i - 1]); 
                }
            }
            return maxProfit;
    }
    }
}
