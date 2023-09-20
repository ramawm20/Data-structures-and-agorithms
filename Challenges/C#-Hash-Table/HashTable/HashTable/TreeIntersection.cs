using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public  class TreeIntersection
    {
        public class TreeNode
        {
            public int Value { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(int value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }
        public static HashSet<int> TreeIntersectionValues(TreeNode root1, TreeNode root2)
        {
            HashSet<int> commonValues = new HashSet<int>();

 
            HashMap valuesMap = new HashMap(100); 

           
            void PopulateValues(TreeNode root)
            {
                if (root == null)
                    return;

                valuesMap.Set(root.Value.ToString(), "value");
                PopulateValues(root.Left);
                PopulateValues(root.Right);
            }

            
            PopulateValues(root1);

          
            void CheckCommonValues(TreeNode root)
            {
                if (root == null)
                    return;

                if (valuesMap.Has(root.Value.ToString()))
                    commonValues.Add(root.Value);

                CheckCommonValues(root.Left);
                CheckCommonValues(root.Right);
            }

            CheckCommonValues(root2);

            return commonValues;
        }
    }

}

