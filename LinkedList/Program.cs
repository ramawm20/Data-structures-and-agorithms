namespace LinkedList
{
    public class Program
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
                bool found = false;
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
                if (!found)
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
            public int kthFromEnd(int k)
            {
                Node current = head;
                int length = 0;
                while (current != null)
                {
                    length += 1;
                    current = current.nextNode;
                }
                if (k > length || k == length)

                {
                    throw new Exception($"Error the value {k} is equal or greater than the" +
                        $" size of the linked list");
                }
                else if (k < 0)
                {
                    throw new Exception($"Error index can't be negative");
                }
                current = head;
                int count = 1;
                int index = length - k;

                while(count<index)
                {
                    current=current.nextNode;
                    count++;
                }
                //  throw new ArgumentException("Invalid value of k.");
                return current.value;
            }

            static void Main(string[] args)
            {
                LinkedList newList = new LinkedList();
                newList.Insert(5);
                newList.Insert(4);
                newList.Insert(3);
                newList.Insert(2);
                newList.Insert(1);



                string res;
                res = newList.toString();
                Console.WriteLine(res);



                Console.WriteLine("0  "+newList.kthFromEnd(0));
                Console.WriteLine("1  "+newList.kthFromEnd(1));
                Console.WriteLine("2  "+newList.kthFromEnd(2));
                Console.WriteLine("3  "+newList.kthFromEnd(3));
                Console.WriteLine("4  "+ newList.kthFromEnd(4));
                Console.WriteLine("5  " + newList.kthFromEnd(9));






            }
        }
    }
}