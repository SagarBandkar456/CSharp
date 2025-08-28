using System;


public class VerticalOrder987
{
    public IList<IList<int>> VerticalTraversal(TreeNode root)
    {
        IList<IList<int>> res = new List<IList<int>>();
        if (root == null) return res;

        // column -> list of values
        Dictionary<int, List<int>> map = new();
        Queue<(TreeNode node, int col)> q = new();
        q.Enqueue((root, 0));

        int minCol = 0, maxCol = 0;

        while (q.Count > 0)
        {
            var (node, col) = q.Dequeue();

            if (!map.ContainsKey(col)) map[col] = new List<int>();
            map[col].Add(node.val);

            minCol = Math.Min(minCol, col);
            maxCol = Math.Max(maxCol, col);

            if (node.left != null) q.Enqueue((node.left, col - 1));
            if (node.right != null) q.Enqueue((node.right, col + 1));
        }

        for (int c = minCol; c <= maxCol; c++)
        {
            res.Add(map[c]);
        }

        return res;
    }


    
}