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
        [Fact]
        public void TestAnimalShelterHappyPath()
        {
            //Arrange
            Program.AnimalShelter animalShelter = new Program.AnimalShelter();
            Program.Animal animal1 = new Program.Animal("Lolo","cat");
            Program.Animal animal2 = new Program.Animal("Rockey", "dog");

            //Act
            animalShelter.Enqueue(animal1);
            animalShelter.Enqueue(animal2);

            //Assert
            Assert.Equal(1,animalShelter.Dogs.count);
            Assert.Equal(1, animalShelter.Cats.count);
            Assert.Equal("Lolo", animal1.Name);
            Assert.Equal("Rockey", animal2.Name);

        }
        [Fact]
        public void TestAnimalShelterInvalidSpecies()
        {
            Program.AnimalShelter animalShelter = new Program.AnimalShelter();
            Program.Animal animal1 = new Program.Animal("Lolo", "bird");

            Assert.Throws<Exception>(() => animalShelter.Enqueue(animal1));

        }
        [Fact]
        public void TestAnimalShelterDequeueAnimals()
        {
            //Arrange
            Program.AnimalShelter animalShelter = new Program.AnimalShelter();

            //Act
            Program.Animal animal1 = new Program.Animal("Lolo", "cat");
            Program.Animal animal2 = new Program.Animal("Rokey", "dog");

            animalShelter.Enqueue(animal1);
            animalShelter.Enqueue(animal2);

            Program.Animal DeAnimal1 = animalShelter.Dequeu("cat");
            Program.Animal DeAnimal2 = animalShelter.Dequeu("dog");

            //Assert
            Assert.Equal("Lolo",DeAnimal1.Name );
            Assert.Equal("Rokey", DeAnimal2.Name);

        }
        [Fact]
        public void TestAnimalShelterDequeueInvalidSpecies()
        {
            //Arrange
            Program.AnimalShelter animalShelter = new Program.AnimalShelter();

            //Act
            Program.Animal ActualAnimal =animalShelter.Dequeu("bird");

            //Assert
            Assert.Equal(null,ActualAnimal);
        }
        [Fact]

        public void testBSTInisiateEmptyTree()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            Assert.Null(bst.Root);
        }
        [Fact]
        public void testBSTInisiateTreeWithSingleRoot()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            bst.Add(3);

            int result = bst.Root.value;
            Assert.Equal(3,result);
        }
        [Fact]
        public void CanSuccessfullyAddLeft_RightChild()
        {
            // Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            // Act
            bst.Add(10);
            bst.Add(5); 
            bst.Add(15); 

            // Assert
            Assert.Equal( 10, bst.Root.value);
            Assert.Equal(bst.Root.leftNode.value, 5);
            Assert.Equal(bst.Root.rightNode.value, 15);
        }
        [Fact]
        public void ReturnCollectionFromPreOrder()
        {
            //Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            // Act
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            List<int> excpected=new List<int>() { 10,5,15};
            List<int> actual = bst.preOrder();


            //Assert
            Assert.Equal(excpected, actual);    
        }
        [Fact]
        public void ReturnCollectionFrominOrder()
        {
            //Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            // Act
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            List<int> excpected = new List<int>() { 5,10,15};
            List<int> actual = bst.inOrder();


            //Assert
            Assert.Equal(excpected, actual);
        }
        [Fact]
        public void ReturnCollectionFromPostOrder()
        {
            //Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            // Act
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            List<int> excpected = new List<int>() { 5,15,10 };
            List<int> actual = bst.postOrder();


            //Assert
            Assert.Equal(excpected, actual);
        }
        [Fact]
     
        public void ReturnTrueFromContains()
        {
            //Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
       


            // Act
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);



            //Assert
            Assert.True(bst.Contains(10));
        }
        [Fact]

        public void ReturnFalseFromContains()
        {
            //Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            // Act
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            //Assert
            Assert.False(bst.Contains(20));
        }
        [Fact]
        public void FindMaxValueEmptyTree()
        {
            // Arrange
            BinaryTree<int> binaryTree = new BinaryTree<int>();

            // Act & Assert
            Assert.Throws<Exception>(() => binaryTree.FindMaxValue());
        }
        [Fact]
        public void FindMaxValueSuccess()
        {
            // Arrange
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Root = new NodeTrees<int>(10);
            binaryTree.Root.leftNode = new NodeTrees<int>(5);
            binaryTree.Root.rightNode = new NodeTrees<int>(15);
           

            // Act
            int maxValue = binaryTree.FindMaxValue();

            // Assert
            Assert.Equal(15, maxValue);
        }


        [Fact]
        public void TestBreadthFirstMethodTreeWithOneNode()
        {
            // Arrange
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new NodeTrees<int>(10);

            // Act
            List<int> result = tree.BreadthFirst();

            // Assert
            Assert.Equal(new List<int> { 10 }, result);
        }
        [Fact]
        public void TestBreadthFirstTreeWithMultiNodes()
        {
            // Arrange
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(7);
            tree.Add(12);

            // Act
            List<int> result = tree.BreadthFirst();

            // Assert
            Assert.Equal(new List<int> { 10, 5, 15, 7, 12 }, result);
        }


        [Fact]
        public void TestFizzBuzzTreeTransform()
        {
            
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(15); 
            tree.Add(9);  
            tree.Add(25); 
            tree.Add(7); 

           
            BinarySearchTree<string> newTree = tree.FizzBuzzTreeTransform();

            
            var preOrderRes = newTree.preOrder();
            Assert.Equal(new List<string> { "FizzBuzz", "Fizz", "7", "Buzz" }, preOrderRes);
        }
		[Fact]
		public void TestMergeSortEmptyArray()
		{
			int[] arr = new int[0];
			MergeSort.MergeSortAlgo(arr);
			Assert.Empty(arr);
		}
		[Fact]
		public void TestMergeSortSingleElementArray()
		{
			int[] arr = { 5 };
			MergeSort.MergeSortAlgo(arr);
			Assert.Equal(new int[] { 5 }, arr);
		}

		[Fact]
		public void TestMergeSortSortedArray()
		{
			int[] arr = { 1, 2, 3, 4, 5 };
			MergeSort.MergeSortAlgo(arr);
			Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, arr);
		}

		[Fact]
		public void TestMergeSortReverseSortedArray()
		{
			int[] arr = { 5, 4, 3, 2, 1 };
			MergeSort.MergeSortAlgo(arr);
			Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, arr);
		}

		[Fact]
		public void TestMergeSortUnsortedArray()
		{
			int[] arr = { 3, 1, 4, 5, 2 };
			MergeSort.MergeSortAlgo(arr);
			Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, arr);
		}

		[Fact]
		public void TestMergeSortLargeArray()
		{
			int[] arr = { 7, 13, 2, 9, 11, 5, 1, 6, 4, 3, 8, 12, 10 };
			MergeSort.MergeSortAlgo(arr);
			Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, arr);
		}

	}
}