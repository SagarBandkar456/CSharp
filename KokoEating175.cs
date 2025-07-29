using System;

public class KokoEating175
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int left = 1;
        int right = piles.Max();

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (GetBananaCount(piles, h, mid) <= h)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }

    public long GetBananaCount(int[] piles, int h, int k)
    {
        long total = 0;
        for (int i = 0; i < piles.Length; i++)
        {
            if (piles[i] % k == 0) total += (piles[i] / k);
            else total += (piles[i] / k) + 1;
        }

        return total;
    }
}