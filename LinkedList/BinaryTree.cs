using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedList.Program;

namespace LinkedList
{
    public class BinaryTree<T>
    {
        public NodeTrees<T> Root;

       

        public BinaryTree()
        {
            Root = null;
        }

       
        public List<T> preOrder()
        {
            List<T> result = new List<T>();
            preOrderTraversal(Root, result);
            return result;
        }
        public void preOrderTraversal(NodeTrees<T> node, List<T> result)
        {
            if (node != null) 
            {
                result.Add(node.value);
                preOrderTraversal(node.leftNode, result);
                preOrderTraversal(node.rightNode, result);
            }
           


        }
        public List<T> inOrder()
        {
            List<T> result = new List<T>();
            inOrderTraversal(Root, result);
            return result;
        }
        public void inOrderTraversal(NodeTrees<T> node, List<T> result)
        {
            if (node != null)
            {
                inOrderTraversal(node.leftNode, result);
                result.Add(node.value);
                inOrderTraversal(node.rightNode, result);
            }

        }

        public List<T> postOrder()
        {
            List<T> result = new List<T>();
            postOrderTraversal(Root, result);
            return result;
        }
        public void postOrderTraversal(NodeTrees<T> node, List<T> result)
        {
            if (node != null)
            {
                postOrderTraversal(node.leftNode, result);
                postOrderTraversal(node.rightNode, result);
                result.Add(node.value);

            }

        }






    }
}
