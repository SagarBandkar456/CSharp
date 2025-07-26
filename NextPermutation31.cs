using System;

public class NextPermutation31
{
    public void NextPermutation(int[] nums)
    {
        int index = -1;
        int len = nums.Length;
        for (int i = len - 2; i > 0; i--)
        {
            if (nums[i] < nums[i + 1])
            {
                index = i;
                break;
            }
        }

        if (index == -1) Array.Reverse(nums, 0, len - 1);

        for (int i = len - 1; i >= 0; i--)
        {
            if (nums[i] > nums[index])
            {
                int temp = nums[i];
                nums[i] = nums[index];
                nums[index] = temp;
                break;
            }
        }

        Array.Reverse(nums, index + 1, len - index - 1);
    }
}