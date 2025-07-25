using System;

public class MissingNumber268
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int sumOfNatural = (n * (n + 1) / 2);
        int sum = nums.Sum(a => a);

        return sumOfNatural - sum;
    }
}