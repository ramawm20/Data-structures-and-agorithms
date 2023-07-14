using LinkedList;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using Xunit.Sdk;

namespace testLinkedList
{
    public class UnitTest1
    {
        [Fact]
        public void instantiateEmptyLinkedList()
        {
            Program.LinkedList newList= new Program.LinkedList();
            Assert.Null(newList.head);

        }
        [Fact]
        public void insertIntoTheLinkedList()
        {
            Program.LinkedList newList = new Program.LinkedList();

            int value = 30;

            newList.Insert(value);
            Assert.Equal(value, newList.head.value);
        }
        [Fact]
    
      
        public void returningFromIncludes()
        {
            int value1 = 30;
            int value2 = 40;
            Program.LinkedList newList = new Program.LinkedList();
            newList.Insert(value1);
            Assert.Equal(true,newList.Includes(value1));
            Assert.Equal(false, newList.Includes(value2));

        }
        [Fact]
        public void returnFromToString()
        {
            Program.LinkedList newList = new Program.LinkedList();

            int v1, v2, v3;
            v1 = 30;
            v2 = 40;
            v3 = 50;

            newList.Insert(v1);
            newList.Insert(v2);
            newList.Insert(v3);

            string expected = $"{{{v3}}} -> {{{v2}}} -> {{{v1}}} -> NULL";
            Assert.Equal(expected,newList.toString());
            //Test if the head points to the first node
            
            Assert.Equal(v3,newList.head.value);  
            
        }
        [Fact]
        public void addNodeToTheEnd()
        {
            Program.LinkedList newList= new Program.LinkedList();
            int v1, v2, v3;
            v1 = 30;
            v2 = 40;
            v3 = 50;

            newList.Insert(v1);
            newList.Insert(v2);
            newList.Insert(v3);
            newList.append(20);

            string expected1 = $"{{{v3}}} -> {{{v2}}} -> {{{v1}}} -> {{{20}}} -> NULL";
            Assert.Equal(expected1,newList.toString());

        }
        [Fact]
        public void addMultipleNodesTotheEnd() {

            Program.LinkedList newList = new Program.LinkedList();
            int v1, v2, v3;
            v1 = 30;
            v2 = 40;
            v3 = 50;

            newList.Insert(v1);
            newList.Insert(v2);
            newList.Insert(v3);
            newList.append(20);
            newList.append(10);
            newList.append(9);
            newList.append(8);

            string expected = $"{{{v3}}} -> {{{v2}}} -> {{{v1}}} -> {{{20}}} -> {{{10}}} -> {{{9}}} -> {{{8}}} -> NULL";
            Assert.Equal(expected, newList.toString());

        }
        [Fact]
        

        public void canInsertBeforeTheMiddle()
        {
            Program.LinkedList newList = new Program.LinkedList();
            int v1, v2, v3,v4;
            v1 = 30;
            v2 = 40;
            v3 = 50;
            v4 = 60;

            newList.Insert(v4);
            newList.Insert(v3);
            newList.Insert(v2);
            newList.Insert(v1);
            
            int newValue=45;

            newList.insertBefore(v3, newValue);


            string expected = $"{{{v1}}} -> {{{v2}}} -> {{{newValue}}} -> {{{v3}}} -> {{{v4}}} -> NULL";
            Assert.Equal(expected, newList.toString());

        }
        [Fact]


        public void canInsertBeforeTheFirstNode()
        {
            Program.LinkedList newList = new Program.LinkedList();
            int v1, v2, v3, v4;
            v1 = 30;
            v2 = 40;
            v3 = 50;
            v4 = 60;

            newList.Insert(v4);
            newList.Insert(v3);
            newList.Insert(v2);
            newList.Insert(v1);

            int newValue = 20;

            newList.insertBefore(v1, newValue);


            string expected = $"{{{newValue}}} -> {{{v1}}} -> {{{v2}}} -> {{{v3}}} -> {{{v4}}} -> NULL";
            Assert.Equal(expected, newList.toString());

        }
        [Fact]
        public void canInsertAfterTheMiddle()
        {
            Program.LinkedList newList = new Program.LinkedList();
            int v1, v2, v3, v4;
            v1 = 30;
            v2 = 40;
            v3 = 50;
            v4 = 60;

            newList.Insert(v4);
            newList.Insert(v3);
            newList.Insert(v2);
            newList.Insert(v1);

            int newValue =45;

            newList.insertAfter(v2, newValue);


            string expected = $"{{{v1}}} -> {{{v2}}} -> {{{newValue}}} -> {{{v3}}} -> {{{v4}}} -> NULL";
            Assert.Equal(expected, newList.toString());

        }
        [Fact]
        public void canInsertAfterTheLast()
        {
            Program.LinkedList newList = new Program.LinkedList();
            int v1, v2, v3, v4;
            v1 = 30;
            v2 = 40;
            v3 = 50;
            v4 = 60;

            newList.Insert(v4);
            newList.Insert(v3);
            newList.Insert(v2);
            newList.Insert(v1);

            int newValue = 70;

            newList.insertAfter(v4, newValue);


            string expected = $"{{{v1}}} -> {{{v2}}} -> {{{v3}}} -> {{{v4}}} -> {{{newValue}}} -> NULL";
            Assert.Equal(expected, newList.toString());

        }
        [Fact]
        public void canDeleteNode()
        {
            Program.LinkedList newList = new Program.LinkedList();
            int v1, v2, v3, v4;
            v1 = 30;
            v2 = 40;
            v3 = 50;
            v4 = 60;

            newList.Insert(v4);
            newList.Insert(v3);
            newList.Insert(v2);
            newList.Insert(v1);

            int value=60;

            newList.deleteNode(value);


            string expected = $"{{{v1}}} -> {{{v2}}} -> {{{v3}}} -> NULL";
            Assert.Equal(expected, newList.toString());

        }
        [Fact]
        public void TestHappyPathforKthMethod()
        {
            Program.LinkedList newList = new Program.LinkedList();
            newList.Insert(5);
            newList.Insert(4);
            newList.Insert(3);
            newList.Insert(2);
            newList.Insert(1);

            Assert.Equal(2, newList.kthFromEnd(3));
            Assert.Equal(5, newList.kthFromEnd(0));
            Assert.Equal(1, newList.kthFromEnd(4));
        }
        [Fact]
        public void TestKIsEqualOrGreaterforKthMetgod()
        {
            Program.LinkedList newList = new Program.LinkedList();
            newList.Insert(5);
            newList.Insert(4);
            newList.Insert(3);
            newList.Insert(2);
            newList.Insert(1);

            Assert.Throws<Exception>(() => newList.kthFromEnd(5));
            Assert.Throws<Exception>(() => newList.kthFromEnd(8));

        }
        [Fact]
        public void TestKIsNegativeforKthMetgod()
        {
            Program.LinkedList newList = new Program.LinkedList();
            newList.Insert(5);
            newList.Insert(4);
            newList.Insert(3);
            newList.Insert(2);
            newList.Insert(1);

            Assert.Throws<Exception>(() => newList.kthFromEnd(-2));
           

        }
        [Fact]
        public void TestLinkListOfSizeOneforKthMetgod()
        {
            Program.LinkedList newList = new Program.LinkedList();
            newList.Insert(5);
           

            Assert.Throws<Exception>(() => newList.kthFromEnd(2));
            Assert.Throws<Exception>(() => newList.kthFromEnd(-1));
            Assert.Throws<Exception>(() => newList.kthFromEnd(-2));
            Assert.Equal(5, newList.kthFromEnd(0));

        }
        [Fact]
        public void TestZipListsHappyPath()
        {
            //Arrange
            Program.LinkedList List1 = new Program.LinkedList();
            Program.LinkedList List2 = new Program.LinkedList();

            List1.Insert(1);
            List1.append(3);
            List1.append(5);
            List2.Insert(2);
            List2.append(4);

            Program.LinkedList r1 = new Program.LinkedList();
            r1.Insert(1);
            r1.append(2);
            r1.append(3);
            r1.append(4);
            r1.append(5);

            //Act
            Program.LinkedList r2=new Program.LinkedList();
            r2=r2.zipLists(List1,List2);

            string expected=r1.toString();
            string actual=r2.toString();

            //Assert
            Assert.Equal(expected, actual); 
           
        }
        [Fact]
        public void TestZipListsTestOneNull() 
        {
            //Arrange
            Program.LinkedList List1 = new Program.LinkedList();
            Program.LinkedList List2 = new Program.LinkedList();

            List1.Insert(1);
            List1.append(3);
            List1.append(5);
           

            Program.LinkedList result = new Program.LinkedList();
            result.Insert(1);
            result.append(3);
            result.append(5);

            //Act
            string expected = List1.toString();

            Program.LinkedList r2 = new Program.LinkedList();
            r2 = r2.zipLists(List1, List2);

            string actual = r2.toString();

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestZipListsTestBothNull()
        {
            //Arrange
            Program.LinkedList List1 = new Program.LinkedList();
            Program.LinkedList List2 = new Program.LinkedList();

            //Act
            string expected = "NULL";

            Program.LinkedList r2 = new Program.LinkedList();
            r2 = r2.zipLists(List1, List2);

            string actual = r2.toString();

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CanPushOntoStack()
        {
            Program.Stack<int> newStack = new Program.Stack<int>();  

            newStack.Push(1);

            Assert.Equal(1, newStack.peek());
        }
        [Fact]
        public void CanPushMultipleValuesOntoStack()
        {
            Program.Stack<int> newStack = new Program.Stack<int>();

            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);

            Assert.Equal(3, newStack.peek());
            Assert.False(newStack.isEmpty());
                
        }
        [Fact]
        public void CanPopOfstack()
        {
            Program.Stack<int> newStack = new Program.Stack<int>();

            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);

            Assert.Equal(3, newStack.Pop());
            Assert.Equal(2, newStack.Pop());
            Assert.Equal(1, newStack.Pop());
            //Empty stack after multiple pops
            Assert.True(newStack.isEmpty());

        }
        [Fact]
        public void CallingPopOrPeekOnEmptyStack()
        {
            Program.Stack<int> newStack = new Program.Stack<int>();

            Assert.True(newStack.isEmpty());
            Assert.Throws<Exception>(() => newStack.Pop());
        }
        [Fact]
        public void CanEnQueueIntoQueue()
        {
            Program.Queue<string> queue = new Program.Queue<string>();

            queue.enQueue("Hello");
            queue.enQueue("From");
            queue.enQueue("CC 10");

            Assert.False(queue.isEmpty());
            Assert.Equal("Hello", queue.Peek());
        }
        [Fact]
        public void CanDeQueueFromQueue()
        {
            Program.Queue<string> queue = new Program.Queue<string>();

            queue.enQueue("Hello");
            queue.enQueue("From");
            queue.enQueue("CC 10");

            Assert.Equal("Hello", queue.deQueue());
            Assert.Equal("From", queue.deQueue());
            Assert.Equal("CC 10", queue.deQueue());
            Assert.True(queue.isEmpty());


        }
        [Fact]
        public void CanDeQueueOrPeekOnEmpty()
        {
            Program.Queue<string> queue = new Program.Queue<string>();

            Assert.Throws<Exception>(() => queue.deQueue());
        }


    }
}