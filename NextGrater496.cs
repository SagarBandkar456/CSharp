using System;

public class NextGreater496
{

    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        int[] res = new int[nums1.Length];
        Stack<int> st = new();
        Dictionary<int, int> nextGreater = new();

        for (int i = nums2.Length - 1; i >= 0; i--)
        {
            while (st.Count > 0 && st.Peek() <= nums2[i])
                st.Pop();

            nextGreater[nums2[i]] = st.Count <= 0 ? -1 : st.Peek();
            st.Push(nums2[i]);
        }

        for (int i = 0; i < nums1.Length; i++)
            res[i] = nextGreater[nums1[i]];

        return res;
    }
}