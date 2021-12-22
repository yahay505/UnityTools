using System.Collections.Generic;

namespace YahayTools
{
    public class TreeNode<T>
    {
        public TreeNode<T> parent;
        public T node;
        public List<TreeNode<T>> children;
    }
}


