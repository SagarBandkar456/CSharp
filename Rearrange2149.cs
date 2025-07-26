using System;

public class Rearrange2149
{
    public int[] RearrangeArray(int[] nums)
    {
        int[] res = new int[nums.Length];
        int pos = 0;
        int neg = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                res[pos] = nums[i];
                pos = pos + 2;
            }
            else
            {
                res[neg] = nums[i];
                neg = neg + 2;
            }
        }

        return res;
    }
}