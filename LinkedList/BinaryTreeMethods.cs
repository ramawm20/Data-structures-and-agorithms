using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class BinaryTreeMethods
    {
        public static List<T> BreadthFirst<T>(this BinaryTree<T> tree)
        {
            List<T> result = new List<T>();

            if (tree.Root == null)
                return result;

            Queue<NodeTrees<T>> queue = new Queue<NodeTrees<T>>();
            queue.Enqueue(tree.Root);

            while (queue.Count > 0)
            {
                NodeTrees<T> node = queue.Dequeue();
                result.Add(node.value);

                if (node.leftNode != null)
                    queue.Enqueue(node.leftNode);

                if (node.rightNode != null)
                    queue.Enqueue(node.rightNode);
            }

            return result;
        }
    }
}
