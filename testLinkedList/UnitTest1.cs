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
        

    }
}