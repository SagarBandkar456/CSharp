using System;

public class SumOfSub2104
{
    public long SubArrayRanges(int[] nums)
    {
        long res = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int max = nums[i];
            int min = nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                max = Math.Max(max, nums[j]);
                min = Math.Min(min, nums[j]);

                res += (long)max - (long)min;
            }
        }

        return res;
    }
}