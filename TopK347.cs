using System;

public class TopK347
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> dt = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dt.ContainsKey(nums[i]))
                dt[nums[i]]++;
            else
                dt[nums[i]] = 1;
        }

        PriorityQueue<int, int> pq = new();
        foreach (var item in dt.Keys)
        {
            pq.Enqueue(item, dt[item]);

            if (pq.Count > k)
                pq.Dequeue();
        }

    }
}