using System;

public class Majority169
{
    public int MajorityElement(int[] nums)
    {
        int cnt = 0;
        int ele = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (cnt == 0)
            {
                cnt++;
                ele = nums[i];
            }
            else if (nums[i] == ele) cnt++;
            else cnt--;
        }

        int cnt1 = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (ele == nums[i]) cnt1++;
        }

        if (cnt1 > (nums.Length / 2)) return ele;

        return -1;
    }
}