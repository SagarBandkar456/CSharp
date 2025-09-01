using System;

public class ValidateBinary98
{
    public bool IsValidBST(TreeNode root)
    {
        return Solve(root, long.MinValue, long.MaxValue);
    }

    public bool Solve(TreeNode root, long min, long max)
    {
        if (root == null) return true;

        if (root.val <= min || root.val >= max) return false;
        return Solve(root.left, min, root.val) &&
               Solve(root.right, root.val, max);
    }
}