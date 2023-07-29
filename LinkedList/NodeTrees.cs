using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class NodeTrees<T>
    {
        public T value {  get; set; }

        public NodeTrees<T> leftNode { get; set; }

        public NodeTrees<T> rightNode { get; set; }


        public NodeTrees(T value)
        {
            this.value = value;
            leftNode = null;
            rightNode = null;
        }
    }
}
