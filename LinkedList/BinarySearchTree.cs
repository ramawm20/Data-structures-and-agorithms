using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedList.Program;

namespace LinkedList
{
    public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable<T>
    {
        public void Add(T value)
        {
            Root = AddNode(Root, value);
        }
        private NodeTrees<T> AddNode(NodeTrees<T> node, T value)
        {
            if (node == null)
                return new NodeTrees<T>(value);


            if (value.CompareTo(node.value) < 0)
                node.leftNode = AddNode(node.leftNode, value);

            else if (value.CompareTo(node.value) > 0)
                node.rightNode = AddNode(node.rightNode, value);

            return node;
        }
        public bool Contains(int value)
        {
            return ContainsNode(Root, value);
        }

        private bool ContainsNode(NodeTrees<T> node, int value)
        {
            if (node == null)
            {
                return false;
            }

            if (node.value == value)
            {
                return true;
            }
            else if (value < node.value)
            {
                return ContainsNode(node.leftNode, value);
            }
            else
            {
                return ContainsNode(node.rightNode, value);
            }
        }
    }
}
