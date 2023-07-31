
﻿using System.ComponentModel;
using System.Reflection.Metadata;
using static LinkedList.Program;


namespace LinkedList
{
    public class Program
    {
        public static bool ValidateBrackets(string str)
        {

            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                if (c == '[' || c == '(' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ']' || c == ')' || c == '}')
                {
                    char node = stack.Pop();
                    if (node == c)
                    {
                        stack.Pop();
                    }

                }
            }
            return stack.count == 0;
        }
        public class Animal
        {
            public string Name { get; set; }
            public string Species { get; set; }

            public Animal(string Name,string Species)
            {
                this.Name = Name;
                this.Species = Species;
            }
        }
        public class AnimalShelter
        {


            public Queue<Animal> Dogs;
            public Queue<Animal> Cats;

            public AnimalShelter()
            {
                Dogs = new Queue<Animal>();
                Cats = new Queue<Animal>();

            }
            public void Enqueue(Animal animal)
            {
                if (animal.Species == "dog")
                {
                    Dogs.enQueue(animal);
                }
                else if (animal.Species == "cat")
                {
                    Cats.enQueue(animal);
                }
                else
                {
                    throw new Exception("Invalid species, You must just enter Dogs or Cats");
                }
            }
            public Animal Dequeu(string pref)
            {
                if (pref == "dog")
                {
                    return Dogs.deQueue();
                }
                else if (pref == "cat")
                {
                    
                    return Cats.deQueue();
                }
                return null;
            }
        }


        public class pseudoQueue<T>
        {
            private Stack<T> stack1;
            private Stack<T> stack2;

            public pseudoQueue()
            {
                stack1 = new Stack<T>();
                stack2 = new Stack<T>();
            }
            public void Enqueue(T value)
            {
                while (stack1.count > 0)
                {
                    stack2.Push(stack1.Pop());
                }

                stack1.Push(value);

                while (stack2.count > 0)
                {
                    stack1.Push(stack2.Pop());
                }
                
            }
            public T Dequeue()
            {
                if (stack1.count == 0)
                {
                    throw new Exception("The queue is empty.");
                }

                return stack1.Pop();
            }
        }
        public class NodeS<T>
        {
            public T Value { get; set; }
            public NodeS<T> next { get; set; }

            public NodeS(T value)
            {
                this.Value = value;
                this.next = null;
                
            }
        }
        
        public class Queue<T>
        {
            //First node of the Queue
            private NodeS<T> front;
            //last node the Queue
            private NodeS<T> rear;

            public int count;


            public Queue()
            {
                this.front = null;
                this.rear = null;
                this.count = 0;

            }
            public void enQueue(T value)
            {
                NodeS<T> newNode = new NodeS<T>(value);

                if (isEmpty())
                {
                    front = newNode;
                    rear = newNode;
                }
                rear.next = newNode;
                rear = newNode;
                count++;


            }
            public T Peek()
            {
                if (isEmpty())
                {
                    throw new Exception("The queue is empty");

                }
                return front.Value;
            }
            public T deQueue()
            {
                if (isEmpty())
                {
                    throw new Exception("The queue is empty");
                }
                T deleted= front.Value;
                front = front.next;
                if (front == null)
                {
                    rear = null;
                }
                count--;
                return deleted;

            }
            public bool isEmpty()
            {
                return front == null && rear == null;
            }

        }
        public class Stack<T> :LinkedList
        {
          
            private NodeS<T> top;
            public int count;

            public Stack()
            {
                this.top = null;
            }

            public void Push(T value)
            {
                NodeS<T> newNode =new NodeS<T> (value);
                newNode.next = top;
                top = newNode;
                count++;
            }
            public T Pop()
            {
                if (isEmpty())
                {
                    throw new Exception("The stack is empty");
                }

                T value = top.Value;
                top = top.next;
                count--;
                return value;
            }
            public T peek()
            {
                if (isEmpty())
                {
                    throw new Exception("The stack is empty");
                }
                T value = top.Value;
                return value;
            }
            public bool isEmpty()
            {
                return top == null;
            }
        }

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

                Console.WriteLine("Hello");

                BinarySearchTree<int> bt = new BinarySearchTree<int> { };

                bt.Add(3);
                bt.Add(7);
                bt.Add(9);
                bt.Add(34);
                bt.Add(2);

                Console.WriteLine(bt.FindMaxValue());

            }




        }
           

        }
    }
