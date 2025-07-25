using System;

public class MoveZeros283
{
    public void MoveZeroes(int[] nums)
    {
        int i = 0;
        int j = 1;

        while (i < nums.Length && j < nums.Length)
        {
            if (nums[i] == 0 && nums[j] == 0)
            {
                j++;
            }
            else
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                i++;
                j++;
            }
        }
    }
}