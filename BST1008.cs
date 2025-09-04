using System;

public class BST1008
{
    int i = 0;
    public TreeNode BstFromPreorder(int[] preorder)
    {
        return bstHelper(preorder, Int32.MinValue, Int32.MaxValue);
    }

    public TreeNode bstHelper(int[] preorder, int start, int end)
    {
        if (i >= preorder.Length || preorder[i] < start || preorder[i] > end)
            return null;

        int val = preorder[i];
        i++;
        TreeNode node = new TreeNode(val);
        node.left = bstHelper(preorder, start, val);
        node.right = bstHelper(preorder, val, end);

        return node;
    }
}