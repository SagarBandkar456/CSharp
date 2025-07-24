using System;
using System.IO.Pipelines;

public class MostFreqEle1838
{
    public int MaxFrequency(int[] nums, int k)
    {
        Array.Sort(nums);

        int l = 0;
        int r = 0;
        int res = 0;
        long currSum = 0;

        while (r < nums.Length)
        {
            currSum = currSum + nums[r];

            while (nums[r] * (r - l + 1) > currSum + k)
            {
                currSum = currSum - nums[l];
                l++;
            }

            res = Math.Max(res, r - l + 1);
            r++;
        }

        return res;
    }
}