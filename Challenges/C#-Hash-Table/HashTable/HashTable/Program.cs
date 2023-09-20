using static HashTable.TreeIntersection;

namespace HashTable
{
	public class Program
	{
		static void Main(string[] args)
		{
            //HashMap hashMap = new HashMap(10);

            //hashMap.Set("name", "John");
            //hashMap.Set("age", "30");
            //hashMap.Set("city", "New York");

            //hashMap.Print();


            //string name = hashMap.Get("name");
            //Console.WriteLine("Name: " + name);

            //string profession = hashMap.Get("profession");
            //if (profession == null)
            //{
            //	Console.WriteLine("Profession not found.");
            //}


            //hashMap.Set("profession", "Engineer");
            //hashMap.Set("country", "USA");

            //hashMap.Print();

            TreeNode root1 = new TreeNode(150);
            root1.Left = new TreeNode(100);
            root1.Right = new TreeNode(250);
            root1.Left.Left = new TreeNode(75);
            root1.Left.Right = new TreeNode(160);
            root1.Left.Right.Left =new TreeNode(125);
            root1.Left.Right.Right = new TreeNode(175);
            root1.Right.Left = new TreeNode(200);
            root1.Right.Right = new TreeNode(350);
            root1.Right.Right.Left = new TreeNode(300);
            root1.Right.Right.Right = new TreeNode(500);


            TreeNode root2 = new TreeNode(42);
            root2.Left = new TreeNode(100);
            root2.Right = new TreeNode(600);
            root2.Left.Left = new TreeNode(15);
            root2.Left.Right = new TreeNode(160);
            root2.Left.Right.Left = new TreeNode(125);
            root2.Left.Right.Right = new TreeNode(175);
            root2.Right.Left = new TreeNode(200);
            root2.Right.Right = new TreeNode(350);
            root2.Right.Right.Left = new TreeNode(4);
            root2.Right.Right.Right = new TreeNode(500);


           
            
            HashSet<int> commonValues = TreeIntersection.TreeIntersectionValues(root1, root2);

            
            Console.WriteLine("Common Values:");
            foreach (int value in commonValues)
            {
                Console.WriteLine(value);
            }
        }
	}
}