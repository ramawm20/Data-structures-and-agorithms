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
        public bool Contains(T value)
        {
            return ContainsNode(Root, value);
        }

        private bool ContainsNode(NodeTrees<T> node, T value)
        {
         
                if (node == null)
                {
                    return false;
                }

                int compareResult = value.CompareTo(node.value);

                if (compareResult == 0)
                {
                    return true;
                }
                else if (compareResult < 0)
                {
                    return ContainsNode(node.leftNode, value);
                }
                else
                {
                    return ContainsNode(node.rightNode, value);
                }
            }
        public BinarySearchTree<string> FizzBuzzTreeTransform()
        {
            BinarySearchTree<string> newTree = new BinarySearchTree<string>();
            newTree.Root = FizzBuzzTreeTransform(Root);
            return newTree;
        }

        private NodeTrees<string> FizzBuzzTreeTransform(NodeTrees<T> node)
        {
            if (node == null)
                return null;

            NodeTrees<string> newNode = new NodeTrees<string>(TransformValue(node.value));

            newNode.leftNode = FizzBuzzTreeTransform(node.leftNode);
            newNode.rightNode = FizzBuzzTreeTransform(node.rightNode);

            return newNode;
        }

        private string TransformValue(T value)
        {
            if (value is int intValue)
            {
                if (intValue % 3 == 0 && intValue % 5 == 0)
                    return "FizzBuzz";
                if (intValue % 3 == 0)
                    return "Fizz";
                if (intValue % 5 == 0)
                    return "Buzz";
            }

            return value.ToString();
        }
    }


        }
    

