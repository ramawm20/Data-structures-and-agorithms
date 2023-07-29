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

        public List<int> PreOrder()
        {
            List<int> result = new List<int>();
            PreOrderHelper(Root, result);
            return result;
        }

        private void PreOrderHelper(NodeTrees<T> node, List<int> result)
        {
            if (node != null)
            {
                result.Add(node.value);
                PreOrderHelper(node.leftNode, result);
                PreOrderHelper(node.rightNode, result);
            }
        }

     



    }
}
