using System;
using System.Collections;
using System.Collections.Generic;

public class KSmall230
{
    public int KthSmallest(TreeNode root, int k)
    {
        SortedSet<int> sl = new();

        if (root == null) return 0;

        Solve(root, sl);

        return sl.Skip(k - 1).FirstOrDefault();
    }

    public void Solve(TreeNode root, SortedSet<int> sl)
    {
        if (root == null) return;

        sl.Add(root.val);

        Solve(root.left, sl);
        Solve(root.right, sl);
    }
}