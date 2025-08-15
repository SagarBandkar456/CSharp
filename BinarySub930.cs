using System;

public class BinarySub930
{
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        return Solve(nums, goal) - Solve(nums, goal - 1);
    }

    public int Solve(int[] nums, int goal)
    {
        int sum = 0, cnt = 0;
        int left = 0, right = 0;
        int n = nums.Length;

        if (goal < 0) return 0;
        while (right < n)
        {
            sum += nums[right];
            while (sum > goal)
            {
                left++;
                sum -= nums[left];
            }
            cnt += (right - left + 1);
            right++;
        }

        return cnt;
    }
}