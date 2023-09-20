using HashTable;
using static HashTable.TreeIntersection;

namespace TestHash
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{

		}
	
		[Fact]
		public void TestSetAndGet()
		{
			// Arrange
			var hashMap = new HashMap(16);

			// Act
			hashMap.Set("key1", "value1");
			hashMap.Set("key2", "value2");

			// Assert
			Assert.Equal("value1", hashMap.Get("key1"));
			Assert.Equal("value2", hashMap.Get("key2"));
		}

		[Fact]
		public void TestGetNonExistentKey()
		{
			// Arrange
			var hashMap = new HashMap(16);

			// Act
			var value = hashMap.Get("nonexistent");

			// Assert
			Assert.Null(value);
		}

		[Fact]
		public void TestKeys()
		{
			// Arrange
			var hashMap = new HashMap(16);
			hashMap.Set("key1", "value1");
			hashMap.Set("key2", "value2");
			hashMap.Set("key3", "value3");

			// Act
			var keys = hashMap.Keys();

			// Assert
			Assert.Contains("key1", keys);
			Assert.Contains("key2", keys);
			Assert.Contains("key3", keys);
		}

		[Fact]
		public void TestCollisionHandling()
		{
			// Arrange
			var hashMap = new HashMap(16);
			hashMap.Set("key1", "value1");
			hashMap.Set("key17", "value2"); 

			// Act
			var value1 = hashMap.Get("key1");
			var value2 = hashMap.Get("key17");

			// Assert
			Assert.Equal("value1", value1);
			Assert.Equal("value2", value2);
		}

		[Fact]
		public void TestHashInRange()
		{
			// Arrange
			var hashMap = new HashMap(16);

			// Act
			int hashValue = hashMap.Hash("testkey");

			// Assert
			Assert.InRange(hashValue, 0, 15);
		}
        [Fact]
        public void TestCommonValues()
        {

            // Arrange
            TreeNode root1 = new TreeNode(1);
            root1.Left = new TreeNode(2);
            root1.Right = new TreeNode(3);
            root1.Left.Left = new TreeNode(4);
            root1.Left.Right = new TreeNode(5);

            TreeNode root2 = new TreeNode(3);
            root2.Left = new TreeNode(5);
            root2.Right = new TreeNode(7);
            root2.Left.Left = new TreeNode(1);
            root2.Left.Right = new TreeNode(4);

            // Act
            var commonValues = TreeIntersection.TreeIntersectionValues(root1, root2);

            // Assert
            Assert.Contains(1, commonValues);
            Assert.Contains(3, commonValues);
            Assert.Contains(4, commonValues);
            Assert.Contains(5, commonValues);
        }

        [Fact]
        public void TestNoCommonValues()
        {
            //Arrange
            TreeNode root1 = new TreeNode(1);
            TreeNode root2 = new TreeNode(3);
           
			//Act
            var commonValues = TreeIntersection.TreeIntersectionValues(root1, root2);

            // Assert
            Assert.Empty(commonValues);
        }

        [Fact]
        public void TestEmptyTrees()
        {
            // Arrange
            TreeNode root1 = null;
            TreeNode root2 = null;

            // Act
            var commonValues = TreeIntersection.TreeIntersectionValues(root1, root2);

            //Assert
            Assert.Empty(commonValues);
        }

        [Fact]
        public void TestOneEmptyTree()
        {
            //Arrange
            TreeNode root1 = new TreeNode(1);
            TreeNode root2 = null;

			//Act
            var commonValues = TreeIntersection.TreeIntersectionValues(root1, root2);

			//Assert
            Assert.Empty(commonValues);
        }
    }

}
