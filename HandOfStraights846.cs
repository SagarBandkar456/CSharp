using System;

public class HandOfStraights846
{
    public bool IsNStraightHand(int[] hand, int groupSize)
    {
        if (hand.Length % groupSize != 0) return false;

        SortedDictionary<int, int> sd = new();

        foreach (var num in hand)
        {
            if (sd.ContainsKey(num))
                sd[num]++;
            else
                sd[num] = 1;
        }

        while (sd.Count > 0)
        {
            int start = sd.Keys.First();

            for (int i = start; i < start + groupSize; i++)
            {
                if (!sd.ContainsKey(i)) return false;
                if (sd[i] == 1) sd.Remove(i);
                else sd[i]--;
            }
        }

        return true;
    }
}