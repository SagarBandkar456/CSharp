using System;

public class RemoveDuplicate26
{
    public int RemoveDuplicates(int[] nums)
    {
        int i = 0;
        int j = 1;
        int res = 0;

        while (i < nums.Length && j < nums.Length)
        {
            if (nums[i] == nums[j]) j++;
            else
            {
                i++;
                nums[i] = nums[j];
            }
        }
        i++;
        res = i;

        while (i < nums.Length)
        {
            nums[i] = 0;
            i++;
        }

        return res;
    }
}