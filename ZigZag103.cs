using System;

public class ZigZag103
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        IList<IList<int>> res = new List<IList<int>>();
        if (root == null) return res;
        Solve(root, res, 0);

        return res;
    }

    public void Solve(TreeNode root, IList<IList<int>> res, int level)
    {
        if (res.Count < level + 1) res.Add(new List<int>());

        if (level % 2 == 0)
            res[level].Add(root.val);
        else
            res[level].Insert(0, root.val);

        if (root.left != null) Solve(root.left, res, level + 1);
        if (root.right != null) Solve(root.right, res, level + 1);
    }
}