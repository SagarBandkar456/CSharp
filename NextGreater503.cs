using System;

public class NextGreater503
{
    public int[] NextGreaterElements(int[] nums)
    {
        int n = nums.Length;
        int[] res = new int[n];
        Array.Fill(res, -1); // default value if no greater element

        Stack<int> st = new(); // store indices

        for (int i = 0; i < 2 * n; i++)
        {
            int num = nums[i % n];

            while (st.Count > 0 &&  < num)
            {

            }

            if (i < n) st.Push(i);
        }

        return res;
    }
}