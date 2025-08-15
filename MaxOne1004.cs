using System;

public class MaxOne1004
{
    public int LongestOnes(int[] nums, int k)
    {
        int left = 0, right = 0;
        int maxLen = 0, zero = 0;
        int n = nums.Length;

        while (right < n)
        {
            if (nums[right] == 0) zero++;

            while (zero > 0)
            {
                if (nums[right] == 0) zero--;
                left++;
            }

            maxLen = Math.Max(maxLen, right - left + 1);
            right++;
        }

        return maxLen;
    }
}