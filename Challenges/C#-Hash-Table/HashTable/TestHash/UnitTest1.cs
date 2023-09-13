using HashTable;

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
	}

}
