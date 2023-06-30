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
                Node currentNode = head;
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
            public void append(int value)
            {
                Node newNode = new Node(value);
                Node current = head;

                while (current.nextNode != null)
                {
                    current = current.nextNode;
                }
                current.nextNode = newNode;
                newNode.nextNode = null;

            }
            public void insertBefore(int value, int newValue)
            {


                Node newNode = new Node(newValue);
                Node current = head;
                Node insertB;
                bool found= false;
                while (current.nextNode != null)
                {
                    if (head.value == value)
                    {
                        newNode.nextNode = head;
                        head = newNode;
                        found = true;
                        break;
                    }
                    else if (current.nextNode.value == value)
                    {
                        insertB = current.nextNode;
                        current.nextNode = newNode;
                        newNode.nextNode = insertB;
                        found = true;
                        break;
                    }


                    current = current.nextNode;
                }
                if(!found)
                {
                    throw new Exception($"The value {value} you want to add before not found in the linked list");
                }




            }
            public void insertAfter(int value, int newValue)
            {
                Node newNode = new Node(newValue);
                Node current = head;
                Node N;
                bool found = false;

                while (current != null)
                {
                    if (current.value == value)
                    {
                        N = current.nextNode;
                        current.nextNode = newNode;
                        newNode.nextNode = N;
                        found = true;
                        break;
                    }


                    current = current.nextNode;
                }
                if (!found)
                {
                    throw new Exception($"The Value {value} to add after it not found in the linked list");
                }


            }
            public void deleteNode(int value)
            {
                Node newNode = new Node(value);
                Node current = head;
                Node N;
                bool found = false;
          
                    while (current != null && current.nextNode != null)
                    {
                    if (head.value == value)
                    {
                        head = current.nextNode;
                        found = true;
                        break;
                    }
                    else if (current.nextNode.value == value)
                    {
                        N = current.nextNode;
                        N = N.nextNode;
                        current.nextNode = N;
                        found = true;
                        break;
                    }

                        current = current.nextNode;
                    }
                    if (!found) 
                {
                    throw new Exception("Specific value not found in the linked list.");
                }

                
                


            }
     
    }

        static void Main(string[] args)
        {
            LinkedList newList=new LinkedList();
            newList.Insert(2);
            newList.Insert(2);
            newList.Insert(1);


            string res;
            res=newList.toString();
            Console.WriteLine(res);

            

            res = newList.toString();
            Console.WriteLine(res);



        }
    }
}