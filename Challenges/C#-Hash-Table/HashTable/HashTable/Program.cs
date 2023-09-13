namespace HashTable
{
	public class Program
	{
		static void Main(string[] args)
		{
			HashMap hashMap = new HashMap(10);

			hashMap.Set("name", "John");
			hashMap.Set("age", "30");
			hashMap.Set("city", "New York");

			hashMap.Print();


			string name = hashMap.Get("name");
			Console.WriteLine("Name: " + name);

			string profession = hashMap.Get("profession");
			if (profession == null)
			{
				Console.WriteLine("Profession not found.");
			}


			hashMap.Set("profession", "Engineer");
			hashMap.Set("country", "USA");

			hashMap.Print();
		}
	}
}