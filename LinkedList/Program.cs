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
            public int size=0;

            public LinkedList()
            {
                head = null;
            }

            public void Insert(int value)
            {
                Node newNode = new Node(value);
                newNode.nextNode = head;
                head = newNode;
                size++;
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
                size++;

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

                size++;


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
                size++;

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

                size--;



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
            public LinkedList zipLists(LinkedList L1,LinkedList L2)
            {
              
                LinkedList newList = new LinkedList();
                if (L1.head == null && L2.head == null)
                {
                    return newList;
                }

                Node currentF, currentS;
                if (L1.size>L2.size)
                {
                     currentF = L1.head;
                     currentS = L2.head;
                }
                else
                {
                     currentF = L2.head;
                     currentS = L1.head;
                }
                newList.Insert(currentF.value);
                currentF = currentF.nextNode;
                while (currentF !=null )
                {
                    if (currentS == null)
                    {
                        while(currentF != null)
                        {
                            newList.append(currentF.value);
                            currentF = currentF.nextNode; 
                            
                        }
                        break;
                    }
                    newList.append(currentS.value);
                    newList.append(currentF.value);

                    currentF = currentF.nextNode;
                    currentS = currentS.nextNode;

                }
                return newList;
            }

            static void Main(string[] args)
            {
                LinkedList newList = new LinkedList();
                newList.Insert(1);
                newList.append(2);
                newList.append(3);
                newList.append(4);
                newList.append(5);

               

                LinkedList newl= new LinkedList();
                LinkedList l1= new LinkedList();
                LinkedList l2= new LinkedList();


                newl = newl.zipLists(l1, l2);
                string resultOfZip;
                resultOfZip=newl.toString();
                Console.WriteLine(resultOfZip);


                string res;
                res = newList.toString();
                Console.WriteLine(res);





            }
        }
    }
}