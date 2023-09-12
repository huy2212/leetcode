using System;
using System.Collections.Generic;
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int curProfit = 0, maxProfit = 0;
        for (int i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i + 1] - prices[i] > 0)
            {
                curProfit += prices[i + 1] - prices[i];
            }
            else
            {
                maxProfit += curProfit;
                curProfit = 0;
            }
        }
        maxProfit += curProfit;
        return maxProfit;
    }
}