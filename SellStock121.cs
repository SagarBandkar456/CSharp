using System;

public class SellStock121
{
    public int MaxProfit(int[] prices)
    {
        int profit = 0;
        int min = Int32.MaxValue;

        for (int i = 0; i < prices.Length; i++)
        {
            min = Math.Min(min, prices[i]);
            int sell = prices[i] - min;
            profit = Math.Max(profit, sell);
        }

        return profit;
    }
}