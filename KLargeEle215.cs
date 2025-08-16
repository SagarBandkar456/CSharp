using System;

public class KLargeEle215
{
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int, int> pq = new();

        for (int i = 0; i < nums.Length; i++)
        {
            pq.Enqueue(nums[i], nums[i]);
        }

        int j = 1;
        k = nums.Length - k;
        while (pq.Count > 0 && j < k)
        {
            pq.Dequeue();
            j++;
        }

        return pq.Peek();
    }
}