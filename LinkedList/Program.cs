namespace LinkedList
{
    public  class Program
    {
        public class Node
        {
            public int value { get; set; }
            public Node nextNode { get; set; }

            public Node(int value)
            {
                this.value = value;
                nextNode = null;
            }
        }
        public class LinkedList
        {
            public Node head;

            public LinkedList()
            {
                head = null;
            }

            public void Insert(int value)
            {
                Node newNode = new Node(value);
                newNode.nextNode = head;
                head = newNode;
            }

            public bool Includes(int value)
            {
                Node currentNode= head;
                while (currentNode != null)
                {
                    if (currentNode.value == value)
                    {
                        return true;
                    }
                    currentNode = currentNode.nextNode;
                   
                }
                return false;
            }
            public string toString()
            {
                if (head == null)
                {
                    return "NULL";
                }

                Node currentNode = head;
                string res = "";
                while (currentNode != null)
                {
                    res += ($"{{{currentNode.value}}} -> ");
                    currentNode = currentNode.nextNode;
                }
                res += "NULL";
                return res;
            }
        }

        static void Main(string[] args)
        {
            LinkedList newList=new LinkedList();
            newList.Insert(30);
            newList.Insert(40);
            newList.Insert(50);
            newList.Insert(60);

            int value=newList.head.value;
            Console.WriteLine(value );
            
            bool result;
            result=newList.Includes(30);
            Console.WriteLine(result);

            string res;
            res=newList.toString();
            Console.WriteLine(res);

        }
    }
}