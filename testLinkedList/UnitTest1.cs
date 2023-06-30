using LinkedList;
using Newtonsoft.Json.Linq;

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


    }
}