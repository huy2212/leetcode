using System;
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue, maxPrice = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] <= minPrice)
            {
                minPrice = prices[i];
            }
            else
            {
                maxPrice = Math.Max(prices[i] - minPrice, maxPrice);
            }
        }
        return maxPrice;
    }
}