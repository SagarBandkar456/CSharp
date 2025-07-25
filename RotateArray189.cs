using System;

public class RotateArray189
{
    public void Rotate(int[] nums, int k)
    {
        var writePointer = 0;
        for (var readPointer = 0; readPointer < nums.Length; readPointer++)
        {
            if (nums[readPointer] != 0)
            {
                (nums[writePointer], nums[readPointer]) = (nums[readPointer], nums[writePointer]);
                writePointer++;
            }
        }
    }
}