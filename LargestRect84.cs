using System;

public class LargestRect84
{
    public int LargestRectangleArea(int[] heights)
    {
        int maxArea = 0;
        Stack<int> st = new();

        for (int i = 0; i < heights.Length; i++)
        {
            while (st.Count > 0 && heights[st.Peek()] > heights[i])
            {
                int ele = st.Pop();
                int nse = i;
                int pse = st.Count == 0 ? -1 : st.Peek();
                maxArea = Math.Max(maxArea, heights[ele] * (nse - pse - 1));
            }
            st.Push(i);
        }

        // Handle remaining elements in stack
        while (st.Count > 0)
        {
            int ele = st.Pop();
            int nse = heights.Length; // one past the last index
            int pse = st.Count == 0 ? -1 : st.Peek();
            maxArea = Math.Max(maxArea, heights[ele] * (nse - pse - 1));
        }

        return maxArea;

    }
}