using System;

public class BSTDeleteNode450
{
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null) return null;

        if (key < root.val)
            root.left = DeleteNode(root.left, key);
        else if (key > root.val)
            root.right = DeleteNode(root.right, key);
        else
        {
            if (root.right == null && root.left == null) return null;
            else if (root.left == null) return root.right;
            else if (root.right == null) return root.left;
            else
            {
                var temp = root.right;
                while (temp.left != null)
                    temp = temp.left;

                root.val = temp.val;
                root.right = DeleteNode(root.right, temp.val);
            }
        }

        return root;
    }
}