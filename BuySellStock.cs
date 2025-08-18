using System;

public class BuySellStock
{
    public long MaxProfit(int[] prices, int[] strategy, int k)
    {
        long res = 0;

        for (int i = 0; i < strategy.Length; i++)
        {
            res += prices[i] * strategy[i];
        }

        long res2 = 0;
        long res3 = 0;

        int set1=k/ 2;
        for (int i = 0; i < strategy.Length; i++)
        {
            if (i < set1)
                res2 += prices[i] * 0;

            res2 += prices[i] * strategy[i];
        }

        int set2 = k / 2;
        int j = 0;
        for (int i = strategy.Length - 1; i > 0; i--)
        {
            if (j < set1)
            {
                res3 += prices[i] * 1;
                j++;
            }

            res3 += prices[i] * strategy[i];
        }
        return Math.Max(res,Math.Max(res2,res3));
    }
}