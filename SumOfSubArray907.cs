using System;

public class SumOfSubArray907
{
    public int SumSubarrayMins(int[] arr, int index)
    {
        Stack<int> st = new();
        int n = arr.Length;
        int[] left = new int[n];
        int[] right = new int[n];

        int mod = 1000000007;

        for (int i = 0; i < n; i++)
        {
            while (st.Count > 0 && arr[st.Peek()] > arr[i]) st.Pop();

            right[i] = st.Count == 0 ? n : st.Peek();

            st.Push(i);
        }

        st.Clear();

        for (int i = n - 1; i >= 0; i--)
        {
            while (st.Count > 0 && arr[st.Peek()] >= arr[i]) st.Pop();

            left[i] = st.Count == 0 ? n : st.Peek();

            st.Push(i);
        }

        long ans = 0;
        for (int i = 0; i < n; i++)
        {
            long leftCount = i - left[i];     // number of choices to the left
            long rightCount = right[i] - i;   // number of choices to the right

            long contribution = (arr[i] * leftCount % mod) * rightCount % mod;
            ans = (ans + contribution) % mod;
        }

        return (int)ans;
    }
}