namespace BinaryTree
{
    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

    }

    public class BinaryTree
    {
        public TreeNode Root;

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int value)
        {
            Root = InsertRecursively(Root, value);
        }
        private TreeNode InsertRecursively(TreeNode node, int value)
        {
            if (node == null)
            {
                return new TreeNode(value);
            }

            if (value <= node.Value)
            {
                node.Left = InsertRecursively(node.Left, value);
            }
            else
            {
                node.Right = InsertRecursively(node.Right, value);
            }

            return node;
        }

        public bool Search(int value)
        {
           return SearchRecursively(Root, value);
        }

        public bool SearchRecursively(TreeNode node, int value)
        {
            if (node == null) return false;

            if (node.Value == value)
            {
                return true;
            }
            if (value < node.Value)
            {
                return SearchRecursively(node.Left, value);
            }
            else
            {
                return SearchRecursively(node.Right, value);
            }
        }

        public void Remove(int value)
        {
            Root = RemoveRecursively(Root, value);
        }
        private TreeNode RemoveRecursively(TreeNode node, int value)
        {
            if (node == null) return null;

            if (value < node.Value)
                node.Left = RemoveRecursively(node.Left, value);
            else if (value > node.Value)
                node.Right = RemoveRecursively(node.Right, value);
            else
            {
                if (node.Left == null && node.Right == null)
                    return null;
                else if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;
                else
                {
                    TreeNode maxNode = FindMax(node.Left);
                    node.Value = maxNode.Value;
                    node.Left = RemoveRecursively(node.Left, maxNode.Value); // remove duplicated node
                }

            }
            return node;
        }

        private TreeNode FindMax(TreeNode node)
        {
            while (node.Right != null)
            {
                node = node.Right;
            }
            return node;
        }
    }
}
